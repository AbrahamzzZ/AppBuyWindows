﻿using Entidad;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class vtnMenu : Form
    {
        private Usuario nombreUsuarioActual;
        private static Form formularioActivo = null;
        public vtnMenu(Usuario objusuario)
        {
            nombreUsuarioActual = objusuario;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void vtnMenu_Load(object sender, EventArgs e)
        {
            List<Permiso> listaVerificar = new CN_Permiso().Permisos(nombreUsuarioActual.IdUsuario);

            foreach (ToolStripMenuItem iconMenu in menu2.Items)
            {
                bool encontrado = listaVerificar.Any(m => m.NombreMenu == iconMenu.Name);
                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            lbl2.Text = nombreUsuarioActual.NombreCompleto;
            FechaHora.Enabled = true;
        }

        private void verPanel(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuItemVerUsuarios_Click_1(object sender, EventArgs e)
        {
            verPanel(new VtnUsuarios());
        }

        private void menuItemInventario_Click_1(object sender, EventArgs e)
        {
            verPanel(new VtnInventario());
        }

        private void menuItemCategoría_Click(object sender, EventArgs e)
        {
            verPanel(new VtnCategoria());
        }

        private void menuItemProducto_Click_1(object sender, EventArgs e)
        {
            verPanel(new VtnProducto());
        }
        private void menuItemUnidadesMedida_Click(object sender, EventArgs e)
        {
            verPanel(new VtnUnidadMedida());
        }

        private void menuItemRealizarVenta_Click(object sender, EventArgs e)
        {
            verPanel(new VtnVenta(nombreUsuarioActual));
        }
        private void menuItemVerDetallesVenta_Click(object sender, EventArgs e)
        {
            verPanel(new vtnVerDetalleVentas());
        }
        private void menuItemRealizarCompra_Click(object sender, EventArgs e)
        {
            verPanel(new vtnCompra(nombreUsuarioActual));
        }

        private void menuItemVerDetallesCompra_Click(object sender, EventArgs e)
        {
            verPanel(new vtnVerDetalleCompras());
        }
        private void menuItemVerProveedores_Click(object sender, EventArgs e)
        {
            verPanel(new VtnProveedor());
        }

        private void menuItemVerTransportistas_Click(object sender, EventArgs e)
        {
            verPanel(new VtnTransportista());
        }
        private void menuItemVerSucursales_Click(object sender, EventArgs e)
        {
            verPanel(new VtnSucursal());
        }
        private void menuItemVerClientes_Click(object sender, EventArgs e)
        {
            verPanel(new VtnCliente());
        }
        private void menuItemReportesCompras_Click(object sender, EventArgs e)
        {
            verPanel(new vtnReportesCompras());
        }

        private void menuItemGraficasCompras_Click(object sender, EventArgs e)
        {
            verPanel(new vtnGraficaCompras());
        }

        private void menuItemReportesVentas_Click(object sender, EventArgs e)
        {
            verPanel(new vtnReportesVentas());
        }

        private void menuItemGraficasVentas_Click(object sender, EventArgs e)
        {
            verPanel(new vtnGraficaVentas());
        }
        private void menuItemVerOfertas_Click(object sender, EventArgs e)
        {
            verPanel(new vtnOferta());
        }

        private void menuItemVerReclamos_Click(object sender, EventArgs e)
        {
            //verPanel(new VtnReclamo());
        }
        private void menuItemVerNegocio_Click(object sender, EventArgs e)
        {
            verPanel(new vtnNegocio());
        }

        private void menuItemVerAutor_Click(object sender, EventArgs e)
        {
            verPanel(new VtnAutor());
        }

        private void menuItemVerPrograma_Click(object sender, EventArgs e)
        {
            verPanel(new VtnPrograma());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Menú principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
