﻿using ClosedXML.Excel;
using Entidad;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class VtnCliente : Form
    {
        public VtnCliente()
        {
            InitializeComponent();
        }

        private void VtnCliente_Load(object sender, EventArgs e)
        {
            CmbEstado.Items.Add(new { Valor = 1, Texto = "Activo" });
            CmbEstado.Items.Add(new { Valor = 0, Texto = "No Activo" });
            CmbEstado.DisplayMember = "Texto";
            CmbEstado.ValueMember = "Valor";
            CmbEstado.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in tablaCliente.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar")
                {
                    CmbBuscar.Items.Add(new { Valor = columna.Name, Texto = columna.HeaderText });
                }

            }
            CmbBuscar.DisplayMember = "Texto";
            CmbBuscar.ValueMember = "Valor";
            CmbBuscar.SelectedIndex = 0;
            TxtCodigo.Text = GenerarCodigo(4);
            List<Cliente> mostrarCliente = new CN_Cliente().ListarCliente();
            foreach (Cliente cliente in mostrarCliente)
            {
                tablaCliente.Rows.Add(new object[] { "", cliente.IdCliente, cliente.Codigo, cliente.Nombres, cliente.Apellidos, cliente.Cedula, cliente.Telefono, cliente.CorreoElectronico, cliente.Estado == true ? 1 : 0, cliente.Estado == true ? "Activo" : "No Activo" });
            }
            TxtNombres.Select();
        }

        private void BtnExportarExcel_Click(object sender, EventArgs e)
        {
            if (tablaCliente.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos en la tabla para exportar.", "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn columna in tablaCliente.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }
                foreach (DataGridViewRow row in tablaCliente.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), row.Cells[7].Value.ToString(), row.Cells[9].Value.ToString()
                        });
                    }
                }
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.FileName = string.Format("Lista_Clientes.xlsx");
                guardar.Filter = "Excel Files | *.xlsx";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Clientes");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(guardar.FileName);
                        MessageBox.Show("Excel generado correctamente.", "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el Excel.", "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            dynamic selectedItemCmb2 = CmbBuscar.SelectedItem;
            string valorCmb2 = selectedItemCmb2.Valor;
            string columnaFiltro = valorCmb2.ToString();
            int filasVisibles = 0;

            foreach (DataGridViewRow row in tablaCliente.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(TxtBuscar.Text.Trim().ToUpper()))
                {
                    row.Visible = true;
                    filasVisibles++;
                }
                else
                {
                    row.Visible = false;
                }
            }
            // Verificar si hay filas visibles y mostrar un mensaje si no hay
            if (filasVisibles == 0)
            {
                MessageBox.Show("No se encontró información de acuerdo a la opción seleccionada.", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtBuscar.Text = "";
                foreach (DataGridViewRow row in tablaCliente.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            dynamic selectedItemCmb1 = CmbEstado.SelectedItem;
            int valorCmb1 = selectedItemCmb1.Valor;
            string textoCmb1 = selectedItemCmb1.Texto;
            string mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(TxtNombres.Text) || string.IsNullOrWhiteSpace(TxtApellidos.Text) || string.IsNullOrWhiteSpace(TxtCedula.Text) || string.IsNullOrWhiteSpace(TxtTelefono.Text) || string.IsNullOrWhiteSpace(TxtCorreoElectronico.Text))
            {
                string mensajeError = "Por favor, complete los siguientes campos:\n";
                if (string.IsNullOrWhiteSpace(TxtNombres.Text)) mensajeError += "- Nombres del cliente.\n";
                if (string.IsNullOrWhiteSpace(TxtApellidos.Text)) mensajeError += "- Apellidos del cliente.\n";
                if (string.IsNullOrWhiteSpace(TxtCedula.Text)) mensajeError += "- Cedula del cliente.\n";
                if (string.IsNullOrWhiteSpace(TxtTelefono.Text)) mensajeError += "- Telefono del cliente.\n";
                if (string.IsNullOrWhiteSpace(TxtCorreoElectronico.Text)) mensajeError += "- Correo electrónico del cliente.\n";

                MessageBox.Show(mensajeError, "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Cliente agregarCliente = new Cliente()
                {
                    IdCliente = Convert.ToInt32(TxtId.Text),
                    Codigo = TxtCodigo.Text,
                    Nombres = TxtNombres.Text,
                    Apellidos = TxtApellidos.Text,
                    Cedula = TxtCedula.Text,
                    Telefono = TxtTelefono.Text,
                    CorreoElectronico = TxtCorreoElectronico.Text,
                    Estado = valorCmb1 == 1
                };
                int idClienteIngresado = new CN_Cliente().Registrar(agregarCliente, out mensaje);
                if (idClienteIngresado != 0)
                {
                    // Verificar si los elementos seleccionados no son nulos
                    if (selectedItemCmb1 != null)
                    {
                        tablaCliente.Rows.Add(new object[] { "", idClienteIngresado, TxtCodigo.Text, TxtNombres.Text, TxtApellidos.Text, TxtCedula.Text, TxtTelefono.Text, TxtCorreoElectronico.Text, valorCmb1, textoCmb1 });
                        MessageBox.Show("El cliente fue agregado correctamente.", "Agregar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona un valor en ambos comboboxes.", "Tabla Cliente");
                    }
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            dynamic selectedItemCmb1 = CmbEstado.SelectedItem;
            int valorCmb1 = selectedItemCmb1.Valor;
            string textoCmb1 = selectedItemCmb1.Texto;
            string mensaje;

            Cliente clienteModificado = new Cliente()
            {
                IdCliente = Convert.ToInt32(TxtId.Text),
                Codigo = TxtCodigo.Text,
                Nombres = TxtNombres.Text,
                Apellidos = TxtApellidos.Text,
                Cedula = TxtCedula.Text,
                Telefono = TxtTelefono.Text,
                CorreoElectronico = TxtCorreoElectronico.Text,
                Estado = valorCmb1 == 1
            };
            bool modificar = new CN_Cliente().Editar(clienteModificado, out mensaje);
            if (modificar)
            {
                MessageBox.Show("El cliente fue modificado correctamente.", "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int indice = Convert.ToInt32(TxtIndice.Text);
                tablaCliente.Rows[indice].Cells["ID"].Value = clienteModificado.IdCliente;
                tablaCliente.Rows[indice].Cells["Codigo"].Value = clienteModificado.Codigo;
                tablaCliente.Rows[indice].Cells["Nombres"].Value = clienteModificado.Nombres;
                tablaCliente.Rows[indice].Cells["Apellidos"].Value = clienteModificado.Apellidos;
                tablaCliente.Rows[indice].Cells["Cedula"].Value = clienteModificado.Cedula;
                tablaCliente.Rows[indice].Cells["Telefono"].Value = clienteModificado.Telefono;
                tablaCliente.Rows[indice].Cells["CorreoElectronico"].Value = clienteModificado.CorreoElectronico;
                tablaCliente.Rows[indice].Cells["EstadoValor"].Value = clienteModificado.Estado ? 1 : 0;
                tablaCliente.Rows[indice].Cells["Estado"].Value = clienteModificado.Estado ? "Activo" : "No Activo";
                Limpiar();
            }
            else
            {
                MessageBox.Show("Error al modificar la información del cliente: " + mensaje, "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombres.Text) || string.IsNullOrWhiteSpace(TxtApellidos.Text) || string.IsNullOrWhiteSpace(TxtCedula.Text) || string.IsNullOrWhiteSpace(TxtTelefono.Text) || string.IsNullOrWhiteSpace(TxtCorreoElectronico.Text))
            {
                MessageBox.Show("Primero debe selecionar un cliente en la tabla para poder eliminarlo.", "Faltan campos por completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(TxtId.Text) != 0)
                {
                    if (MessageBox.Show("Desea eliminar este cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        Cliente clienteEliminado = new Cliente()
                        {
                            IdCliente = Convert.ToInt32(TxtId.Text),
                        };
                        bool respuesta = new CN_Cliente().Eliminar(clienteEliminado, out mensaje);
                        if (respuesta)
                        {
                            tablaCliente.Rows.RemoveAt(Convert.ToInt32(TxtIndice.Text));
                            MessageBox.Show("El cliente fue eliminado correctamente.", "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void TablaCliente_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var p = Properties.Resources.visto.Width;
                var q = Properties.Resources.visto.Height;
                var r = e.CellBounds.Left + (e.CellBounds.Width - p) / 2;
                var s = e.CellBounds.Top + (e.CellBounds.Height - q) / 2;
                e.Graphics.DrawImage(Properties.Resources.visto, new Rectangle(r, s, p, q));
                e.Handled = true;
            }
        }

        private void TablaCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.tablaCliente.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null && (string)e.Value == "Activo")
                {
                    DataGridViewRow row = tablaCliente.Rows[e.RowIndex];
                    e.CellStyle.BackColor = Color.ForestGreen;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void TablaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaCliente.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    TxtIndice.Text = indice.ToString();
                    TxtId.Text = tablaCliente.Rows[indice].Cells["ID"].Value.ToString();
                    TxtCodigo.Text = tablaCliente.Rows[indice].Cells["Codigo"].Value.ToString();
                    TxtNombres.Text = tablaCliente.Rows[indice].Cells["Nombres"].Value.ToString();
                    TxtApellidos.Text = tablaCliente.Rows[indice].Cells["Apellidos"].Value.ToString();
                    TxtCedula.Text = tablaCliente.Rows[indice].Cells["Cedula"].Value.ToString();
                    TxtTelefono.Text = tablaCliente.Rows[indice].Cells["Telefono"].Value.ToString();
                    TxtCorreoElectronico.Text = tablaCliente.Rows[indice].Cells["CorreoElectronico"].Value.ToString();

                    foreach (dynamic item in CmbEstado.Items)
                    {
                        // Accede a las propiedades Valor y Texto directamente
                        int valor = item.Valor;
                        string texto = item.Texto;

                        if (valor == Convert.ToInt32(tablaCliente.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_cmb = CmbEstado.Items.IndexOf(item);
                            CmbEstado.SelectedIndex = indice_cmb;
                            break;
                        }
                    }
                }
            }
        }

        public void Limpiar()
        {
            TxtIndice.Text = "-1";
            TxtId.Text = "0";
            TxtCodigo.Text = GenerarCodigo(4);
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtCedula.Clear();
            TxtTelefono.Clear();
            TxtCorreoElectronico.Clear();
            CmbEstado.SelectedIndex = 0;
        }

        private string GenerarCodigo(int longitud)
        {
            const string caracteres = "0123456789";
            Random randon = new Random();
            char[] resultado = new char[longitud];
            for (int i = 0; i < longitud; i++)
            {
                resultado[i] = caracteres[randon.Next(caracteres.Length)];
            }
            return new string(resultado);
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Debe ingresar letras y no números.", "Campo Nombres", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                MessageBox.Show("Debe ingresar letras y no números.", "Campo Apellidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Debe ingresar números y no letras.", "Campo Cédula", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Debe ingresar números y no letras.", "Campo Teléfono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
    }
}
