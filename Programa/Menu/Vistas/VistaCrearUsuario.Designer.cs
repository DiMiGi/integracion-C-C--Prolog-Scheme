namespace Menu.Vistas
{
    partial class VistaCrearUsuario
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContra = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContra1 = new System.Windows.Forms.TextBox();
            this.TxtContra2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtJugador = new System.Windows.Forms.TextBox();
            this.LblJugador = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(169, 155);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(30, 32);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(49, 13);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "Usuario: ";
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Location = new System.Drawing.Point(6, 16);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(67, 13);
            this.LblContra.TabIndex = 8;
            this.LblContra.Text = "Contraseña: ";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(120, 29);
            this.TxtUsuario.MaxLength = 32;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(205, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContra1
            // 
            this.TxtContra1.Location = new System.Drawing.Point(79, 13);
            this.TxtContra1.MaxLength = 32;
            this.TxtContra1.Name = "TxtContra1";
            this.TxtContra1.PasswordChar = '*';
            this.TxtContra1.Size = new System.Drawing.Size(205, 20);
            this.TxtContra1.TabIndex = 2;
            this.TxtContra1.UseSystemPasswordChar = true;
            // 
            // TxtContra2
            // 
            this.TxtContra2.Location = new System.Drawing.Point(79, 39);
            this.TxtContra2.MaxLength = 32;
            this.TxtContra2.Name = "TxtContra2";
            this.TxtContra2.PasswordChar = '*';
            this.TxtContra2.Size = new System.Drawing.Size(205, 20);
            this.TxtContra2.TabIndex = 3;
            this.TxtContra2.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtContra1);
            this.groupBox1.Controls.Add(this.TxtContra2);
            this.groupBox1.Controls.Add(this.LblContra);
            this.groupBox1.Location = new System.Drawing.Point(33, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(250, 155);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtJugador
            // 
            this.TxtJugador.Location = new System.Drawing.Point(120, 55);
            this.TxtJugador.MaxLength = 32;
            this.TxtJugador.Name = "TxtJugador";
            this.TxtJugador.Size = new System.Drawing.Size(205, 20);
            this.TxtJugador.TabIndex = 1;
            // 
            // LblJugador
            // 
            this.LblJugador.AutoSize = true;
            this.LblJugador.Location = new System.Drawing.Point(30, 58);
            this.LblJugador.Name = "LblJugador";
            this.LblJugador.Size = new System.Drawing.Size(91, 13);
            this.LblJugador.TabIndex = 7;
            this.LblJugador.Text = "Nombre Jugador: ";
            // 
            // VistaCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.main_fondo;
            this.ClientSize = new System.Drawing.Size(337, 189);
            this.Controls.Add(this.TxtJugador);
            this.Controls.Add(this.LblJugador);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.BtnCancelar);
            this.Name = "VistaCrearUsuario";
            this.Text = "CrearUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContra1;
        private System.Windows.Forms.TextBox TxtContra2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtJugador;
        private System.Windows.Forms.Label LblJugador;
    }
}