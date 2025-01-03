﻿namespace Presentacion
{
    partial class VtnGraficaCompras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.graficaCompra = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCargarDatosVentas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGenerarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.graficaCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // graficaCompra
            // 
            chartArea1.Name = "ChartArea1";
            this.graficaCompra.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficaCompra.Legends.Add(legend1);
            this.graficaCompra.Location = new System.Drawing.Point(387, 29);
            this.graficaCompra.Name = "graficaCompra";
            this.graficaCompra.Size = new System.Drawing.Size(984, 527);
            this.graficaCompra.TabIndex = 65;
            this.graficaCompra.Text = "chart1";
            // 
            // btnCargarDatosVentas
            // 
            this.btnCargarDatosVentas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCargarDatosVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarDatosVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatosVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatosVentas.Location = new System.Drawing.Point(70, 355);
            this.btnCargarDatosVentas.Name = "btnCargarDatosVentas";
            this.btnCargarDatosVentas.Size = new System.Drawing.Size(193, 41);
            this.btnCargarDatosVentas.TabIndex = 64;
            this.btnCargarDatosVentas.Text = "Cargar datos";
            this.btnCargarDatosVentas.UseVisualStyleBackColor = false;
            this.btnCargarDatosVentas.Click += new System.EventHandler(this.btnCargarDatosVentas_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.grafica;
            this.pictureBox1.Location = new System.Drawing.Point(70, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 587);
            this.label2.TabIndex = 62;
            this.label2.Text = "Gráficas de las compras";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnGenerarPDF
            // 
            this.BtnGenerarPDF.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnGenerarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerarPDF.Location = new System.Drawing.Point(70, 402);
            this.BtnGenerarPDF.Name = "BtnGenerarPDF";
            this.BtnGenerarPDF.Size = new System.Drawing.Size(193, 41);
            this.BtnGenerarPDF.TabIndex = 66;
            this.BtnGenerarPDF.Text = "Generar PDF";
            this.BtnGenerarPDF.UseVisualStyleBackColor = false;
            this.BtnGenerarPDF.Click += new System.EventHandler(this.BtnGenerarPDF_Click);
            // 
            // VtnGraficaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1383, 587);
            this.Controls.Add(this.BtnGenerarPDF);
            this.Controls.Add(this.graficaCompra);
            this.Controls.Add(this.btnCargarDatosVentas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Name = "VtnGraficaCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver gráfica de los productos comprados";
            ((System.ComponentModel.ISupportInitialize)(this.graficaCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graficaCompra;
        private System.Windows.Forms.Button btnCargarDatosVentas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenerarPDF;
    }
}