﻿namespace Presentacion.Modales
{
    partial class vtnModalesTransportista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblListaTransportistas = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tablaTransportista = new System.Windows.Forms.DataGridView();
            this.IdTRANSPORTISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTransportista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaTransportistas
            // 
            this.lblListaTransportistas.AutoSize = true;
            this.lblListaTransportistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaTransportistas.Location = new System.Drawing.Point(140, 16);
            this.lblListaTransportistas.Name = "lblListaTransportistas";
            this.lblListaTransportistas.Size = new System.Drawing.Size(324, 32);
            this.lblListaTransportistas.TabIndex = 108;
            this.lblListaTransportistas.Text = "Lista de Transportistas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(530, 76);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 31);
            this.btnBuscar.TabIndex = 107;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(338, 80);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(180, 27);
            this.txt1.TabIndex = 106;
            // 
            // cmb1
            // 
            this.cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(141, 80);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(178, 28);
            this.cmb1.TabIndex = 105;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(12, 82);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(108, 20);
            this.lblBuscar.TabIndex = 104;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // tablaTransportista
            // 
            this.tablaTransportista.AllowUserToAddRows = false;
            this.tablaTransportista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTransportista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaTransportista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaTransportista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTRANSPORTISTA,
            this.Documento,
            this.NombreS,
            this.Estado});
            this.tablaTransportista.Location = new System.Drawing.Point(12, 123);
            this.tablaTransportista.MultiSelect = false;
            this.tablaTransportista.Name = "tablaTransportista";
            this.tablaTransportista.ReadOnly = true;
            this.tablaTransportista.RowHeadersWidth = 51;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaTransportista.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaTransportista.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaTransportista.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.tablaTransportista.RowTemplate.Height = 28;
            this.tablaTransportista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTransportista.Size = new System.Drawing.Size(553, 324);
            this.tablaTransportista.TabIndex = 103;
            this.tablaTransportista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaTransportista_CellDoubleClick);
            this.tablaTransportista.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tablaTransportista_CellFormatting);
            // 
            // IdTRANSPORTISTA
            // 
            this.IdTRANSPORTISTA.HeaderText = "Id";
            this.IdTRANSPORTISTA.MinimumWidth = 6;
            this.IdTRANSPORTISTA.Name = "IdTRANSPORTISTA";
            this.IdTRANSPORTISTA.ReadOnly = true;
            this.IdTRANSPORTISTA.Visible = false;
            this.IdTRANSPORTISTA.Width = 120;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro.Documento";
            this.Documento.MinimumWidth = 6;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 125;
            // 
            // NombreS
            // 
            this.NombreS.HeaderText = "Nombres";
            this.NombreS.MinimumWidth = 6;
            this.NombreS.Name = "NombreS";
            this.NombreS.ReadOnly = true;
            this.NombreS.Width = 110;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // vtnModalesTransportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(577, 463);
            this.Controls.Add(this.lblListaTransportistas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.tablaTransportista);
            this.Name = "vtnModalesTransportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listados de los transportistas";
            this.Load += new System.EventHandler(this.vtnModalesTransportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTransportista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaTransportistas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView tablaTransportista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTRANSPORTISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}