﻿namespace Presentacion
{
    partial class vtnLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vtnLogin));
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.lblOlvidoClave = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblNoDocumento = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHagaClicAqui = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerContrasenia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.Location = new System.Drawing.Point(250, 22);
            this.lblIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(168, 29);
            this.lblIniciarSesion.TabIndex = 22;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // lblOlvidoClave
            // 
            this.lblOlvidoClave.AutoSize = true;
            this.lblOlvidoClave.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOlvidoClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidoClave.Location = new System.Drawing.Point(49, 323);
            this.lblOlvidoClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOlvidoClave.Name = "lblOlvidoClave";
            this.lblOlvidoClave.Size = new System.Drawing.Size(148, 20);
            this.lblOlvidoClave.TabIndex = 20;
            this.lblOlvidoClave.Text = "Olvido su clave?";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(49, 275);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(153, 20);
            this.lblClave.TabIndex = 19;
            this.lblClave.Text = "Ingrese su clave:";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(311, 272);
            this.txt2.Margin = new System.Windows.Forms.Padding(4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(221, 26);
            this.txt2.TabIndex = 18;
            this.txt2.UseSystemPasswordChar = true;
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(311, 222);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(221, 26);
            this.txt1.TabIndex = 17;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // lblNoDocumento
            // 
            this.lblNoDocumento.AutoSize = true;
            this.lblNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDocumento.Location = new System.Drawing.Point(49, 228);
            this.lblNoDocumento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoDocumento.Name = "lblNoDocumento";
            this.lblNoDocumento.Size = new System.Drawing.Size(232, 20);
            this.lblNoDocumento.TabIndex = 16;
            this.lblNoDocumento.Text = "Ingrese su No.Documento:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Wheat;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(377, 382);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 41);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Wheat;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(75, 382);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(155, 41);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHagaClicAqui
            // 
            this.lblHagaClicAqui.AutoSize = true;
            this.lblHagaClicAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHagaClicAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHagaClicAqui.Location = new System.Drawing.Point(219, 323);
            this.lblHagaClicAqui.Name = "lblHagaClicAqui";
            this.lblHagaClicAqui.Size = new System.Drawing.Size(112, 18);
            this.lblHagaClicAqui.TabIndex = 25;
            this.lblHagaClicAqui.Text = "Haga clic aquí...";
            this.lblHagaClicAqui.Click += new System.EventHandler(this.lblHagaClicAqui_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 22);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(46, 20);
            this.lblHora.TabIndex = 24;
            this.lblHora.Text = "hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(261, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.BackColor = System.Drawing.Color.Wheat;
            this.btnVerContrasenia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerContrasenia.Image = global::Presentacion.Properties.Resources.mostrarcontraseña;
            this.btnVerContrasenia.Location = new System.Drawing.Point(550, 269);
            this.btnVerContrasenia.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerContrasenia.Name = "btnVerContrasenia";
            this.btnVerContrasenia.Size = new System.Drawing.Size(39, 32);
            this.btnVerContrasenia.TabIndex = 21;
            this.btnVerContrasenia.UseVisualStyleBackColor = false;
            this.btnVerContrasenia.Click += new System.EventHandler(this.btnVerContrasenia_Click);
            // 
            // vtnLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(625, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.btnVerContrasenia);
            this.Controls.Add(this.lblOlvidoClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblNoDocumento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblHagaClicAqui);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "vtnLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.vtnLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.Button btnVerContrasenia;
        private System.Windows.Forms.Label lblOlvidoClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblNoDocumento;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHagaClicAqui;
        private System.Windows.Forms.Label lblHora;
    }
}
