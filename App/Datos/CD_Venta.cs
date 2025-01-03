﻿using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CD_Venta
    {
        Conexion Conexion = new Conexion();

        //Metodo que muestra el correlativo de cada Venta
        public int ObtenerCorrelativoVenta()
        {
            int IdCorrelativo = 0;
            try
            {
                StringBuilder obtenerCorrelatico = new StringBuilder();
                obtenerCorrelatico.AppendLine("SELECT count (*) + 1 FROM VENTA;");

                SqlCommand cmd = new SqlCommand(obtenerCorrelatico.ToString(), Conexion.ConexionBD());
                cmd.CommandType = CommandType.Text;
                IdCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception co)
            {
                IdCorrelativo = 0;
            }
            return IdCorrelativo;
        }

        //Metodo que suma el stock del Producto despues de cancelar la Venta
        public bool SumarSotck(int idProducto, int cantidad)
        {
            bool Respuesta = true;
            try
            {
                StringBuilder obtenerCorrelatico = new StringBuilder();
                obtenerCorrelatico.AppendLine("UPDATE PRODUCTO SET STOCK = STOCK + @Cantidad WHERE Id_Producto = @idProducto");

                SqlCommand cmd = new SqlCommand(obtenerCorrelatico.ToString(), Conexion.ConexionBD());
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.CommandType = CommandType.Text;

                Respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception ve)
            {
                Respuesta = false;
            }
            return Respuesta;
        }

        //Metodo que resta el stock del Producto despues de la Venta
        public bool RestarSotck(int idProducto, int cantidad)
        {
            bool Respuesta = true;
            try
            {
                StringBuilder obtenerCorrelatico = new StringBuilder();
                obtenerCorrelatico.AppendLine("UPDATE PRODUCTO SET STOCK = STOCK - @Cantidad WHERE Id_Producto = @idProducto");

                SqlCommand cmd = new SqlCommand(obtenerCorrelatico.ToString(), Conexion.ConexionBD());
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                cmd.CommandType = CommandType.Text;

                Respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            catch (Exception ve)
            {
                Respuesta = false;
            }
            return Respuesta;
        }
        
        //Metodo que permite registrar la Venta
        public bool RegistrarVenta(Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;
            try
            {
                SqlCommand cmd = new SqlCommand("PA_REGISTRAR_VENTA", Conexion.ConexionBD());
                cmd.Parameters.AddWithValue("Id_Usuario", obj.oUsuario.IdUsuario);
                cmd.Parameters.AddWithValue("Tipo_Documento", obj.TipoDocumento);
                cmd.Parameters.AddWithValue("Numero_Documento", obj.NumeroDocumento);
                cmd.Parameters.AddWithValue("Id_Cliente", obj.oCliente.IdCliente);
                cmd.Parameters.AddWithValue("Monto_Pago", obj.MontoPago);
                cmd.Parameters.AddWithValue("Monto_Cambio", obj.MontoCambio);
                cmd.Parameters.AddWithValue("Monto_Total", obj.MontoTotal);
                cmd.Parameters.AddWithValue("Descuento", obj.Descuento);
                cmd.Parameters.AddWithValue("Detalle_Venta", DetalleVenta);
                cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
                Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            catch (Exception ve)
            {
                Respuesta = false;
                Mensaje = ve.Message;
            }
            return Respuesta;
        }

        //Metodo que muestra la informacion de la Venta
        public Venta ObtenerVenta(string numero)
        {
            Venta obj = new Venta();
            try
            {
                StringBuilder obtener = new StringBuilder();
                obtener.AppendLine("select v.ID_VENTA, u.NOMBRE_COMPLETO, v.TIPO_DOCUMENTO, v.NUMERO_DOCUMENTO, c.CEDULA, c.NOMBRES, v.MONTO_PAGO, v.MONTO_CAMBIO, v.MONTO_TOTAL, v.DESCUENTO, Convert(char(10),v.FECHA_VENTA,103)[FECHA_VENTA] from VENTA v");
                obtener.AppendLine("inner join USUARIO u on u.ID_USUARIO = v.ID_USUARIO");
                obtener.AppendLine("inner join CLIENTE c on c.ID_CLIENTE = v.ID_CLIENTE");
                obtener.AppendLine("WHERE v.NUMERO_DOCUMENTO = @numero");

                SqlCommand cmd = new SqlCommand(obtener.ToString(), Conexion.ConexionBD());
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    obj = new Venta()
                    {
                        IdVenta = int.Parse(leer["Id_Venta"].ToString()),
                        oUsuario = new Usuario() { NombreCompleto = leer["Nombre_Completo"].ToString() },
                        TipoDocumento = leer["Tipo_Documento"].ToString(),
                        NumeroDocumento = leer["Numero_Documento"].ToString(),
                        oCliente = new Cliente() { Cedula = leer["Cedula"].ToString(), Nombres = leer["Nombres"].ToString() },
                        MontoPago = Convert.ToDecimal(leer["Monto_Pago"].ToString()),
                        MontoCambio = Convert.ToDecimal(leer["Monto_Cambio"].ToString()),
                        MontoTotal = Convert.ToDecimal(leer["Monto_Total"].ToString()),
                        Descuento = Convert.ToDecimal(leer["Descuento"].ToString()),
                        FechaVenta = leer["Fecha_Venta"].ToString()
                    };
                }
            }
            catch (Exception ve)
            {
                obj = new Venta();
            }
            return obj;
        }

        //Metodo que muestra el detalle de la Venta
        public List<Detalle_Venta> ObtenerDetalleVenta(int idVenta)
        {
            List<Detalle_Venta> oLista = new List<Detalle_Venta>();
            try
            {
                StringBuilder obtener = new StringBuilder();
                obtener.AppendLine("SELECT p.NOMBRE_PRODUCTO, dv.PRECIO_VENTA, dv.CANTIDAD_PRODUCTO, dv.SUBTOTAL, dv.DESCUENTO");
                obtener.AppendLine("FROM DETALLE_VENTA DV inner join PRODUCTO p on p.ID_PRODUCTO = dv.ID_PRODUCTO");
                obtener.AppendLine("WHERE dv.ID_VENTA = @idVenta");

                SqlCommand cmd = new SqlCommand(obtener.ToString(), Conexion.ConexionBD());
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    oLista.Add(new Detalle_Venta()
                    {
                        oProducto = new Producto() { Nombre = leer["NOMBRE_PRODUCTO"].ToString() },
                        PrecioVenta = Convert.ToDecimal(leer["PRECIO_VENTA"].ToString()),
                        CantidadProducto = Convert.ToInt32(leer["CANTIDAD_PRODUCTO"].ToString()),
                        SubTotal = Convert.ToDecimal(leer["SUBTOTAL"].ToString()),
                        Descuento = Convert.ToDecimal(leer["DESCUENTO"].ToString())
                    });
                }
            }
            catch (Exception ve)
            {
                oLista = new List<Detalle_Venta>();
            }
            return oLista;
        }

        //Metodo que me muestra los productos mas Vendidos
        public DataTable GraficaProductosVendidos()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder grafica = new StringBuilder();
                grafica.AppendLine("SELECT P.NOMBRE_PRODUCTO, COUNT(DV.ID_PRODUCTO) AS CANTIDAD_VENDIDA FROM DETALLE_VENTA DV");
                grafica.AppendLine("JOIN PRODUCTO P ON DV.ID_PRODUCTO = P.ID_PRODUCTO GROUP BY P.NOMBRE_PRODUCTO;");

                SqlCommand cmd = new SqlCommand(grafica.ToString(), Conexion.ConexionBD());
                SqlDataAdapter data = new SqlDataAdapter(cmd);

                data.Fill(tabla);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return tabla;
        }
        
    }
}
