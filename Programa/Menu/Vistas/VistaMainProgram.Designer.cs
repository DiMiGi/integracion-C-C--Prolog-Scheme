namespace Menu.Vistas
{
    partial class VistaMainProgram
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
            this.BtnNuevoJuego = new System.Windows.Forms.Button();
            this.BtnCargarHistorial = new System.Windows.Forms.Button();
            this.BtnConfiguracion = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pnlDesconectado = new System.Windows.Forms.Panel();
            this.BtnCrearCuenta = new System.Windows.Forms.Button();
            this.TxtContrasenia = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblContra = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.pnlConectado = new System.Windows.Forms.Panel();
            this.lblMejorPuntajeEditar = new System.Windows.Forms.Label();
            this.lblVidaEditar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuarioEditar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnCargarJuego = new System.Windows.Forms.Button();
            this.pnlDesconectado.SuspendLayout();
            this.pnlConectado.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNuevoJuego
            // 
            this.BtnNuevoJuego.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoJuego.Location = new System.Drawing.Point(12, 107);
            this.BtnNuevoJuego.Name = "BtnNuevoJuego";
            this.BtnNuevoJuego.Size = new System.Drawing.Size(140, 30);
            this.BtnNuevoJuego.TabIndex = 1;
            this.BtnNuevoJuego.Text = "Nuevo Juego";
            this.BtnNuevoJuego.UseVisualStyleBackColor = false;
            this.BtnNuevoJuego.Click += new System.EventHandler(this.NuevoJuegoClick);
            // 
            // BtnCargarHistorial
            // 
            this.BtnCargarHistorial.Location = new System.Drawing.Point(12, 179);
            this.BtnCargarHistorial.Name = "BtnCargarHistorial";
            this.BtnCargarHistorial.Size = new System.Drawing.Size(140, 30);
            this.BtnCargarHistorial.TabIndex = 2;
            this.BtnCargarHistorial.Text = "Cargar Historial";
            this.BtnCargarHistorial.UseVisualStyleBackColor = true;
            this.BtnCargarHistorial.Click += new System.EventHandler(this.CargarHistorialClick);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Location = new System.Drawing.Point(12, 215);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Size = new System.Drawing.Size(140, 30);
            this.BtnConfiguracion.TabIndex = 3;
            this.BtnConfiguracion.Text = "Configuraciones";
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.ConfiguracionesClick);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(12, 251);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(140, 30);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.SalirClick);
            // 
            // pnlDesconectado
            // 
            this.pnlDesconectado.Controls.Add(this.BtnCrearCuenta);
            this.pnlDesconectado.Controls.Add(this.TxtContrasenia);
            this.pnlDesconectado.Controls.Add(this.TxtUsuario);
            this.pnlDesconectado.Controls.Add(this.LblContra);
            this.pnlDesconectado.Controls.Add(this.LblUsuario);
            this.pnlDesconectado.Controls.Add(this.BtnConectar);
            this.pnlDesconectado.Location = new System.Drawing.Point(144, 12);
            this.pnlDesconectado.Name = "pnlDesconectado";
            this.pnlDesconectado.Size = new System.Drawing.Size(294, 89);
            this.pnlDesconectado.TabIndex = 5;
            // 
            // BtnCrearCuenta
            // 
            this.BtnCrearCuenta.Location = new System.Drawing.Point(6, 62);
            this.BtnCrearCuenta.Name = "BtnCrearCuenta";
            this.BtnCrearCuenta.Size = new System.Drawing.Size(95, 23);
            this.BtnCrearCuenta.TabIndex = 5;
            this.BtnCrearCuenta.Text = "Crear cuenta";
            this.BtnCrearCuenta.UseVisualStyleBackColor = true;
            this.BtnCrearCuenta.Click += new System.EventHandler(this.CrearCuenta_Click);
            // 
            // TxtContrasenia
            // 
            this.TxtContrasenia.Location = new System.Drawing.Point(77, 36);
            this.TxtContrasenia.MaxLength = 32;
            this.TxtContrasenia.Name = "TxtContrasenia";
            this.TxtContrasenia.Size = new System.Drawing.Size(205, 20);
            this.TxtContrasenia.TabIndex = 4;
            this.TxtContrasenia.UseSystemPasswordChar = true;
            this.TxtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtContrasenia_KeyDown);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(77, 15);
            this.TxtUsuario.MaxLength = 32;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(205, 20);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsuario_KeyDown);
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Location = new System.Drawing.Point(3, 39);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(64, 13);
            this.LblContra.TabIndex = 2;
            this.LblContra.Text = "Contraseña:";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(3, 18);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(46, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario:";
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(207, 62);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 23);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.Conectar_Click);
            // 
            // pnlConectado
            // 
            this.pnlConectado.Controls.Add(this.lblMejorPuntajeEditar);
            this.pnlConectado.Controls.Add(this.lblVidaEditar);
            this.pnlConectado.Controls.Add(this.label4);
            this.pnlConectado.Controls.Add(this.label1);
            this.pnlConectado.Controls.Add(this.lblUsuarioEditar);
            this.pnlConectado.Controls.Add(this.label2);
            this.pnlConectado.Controls.Add(this.btnDesconectar);
            this.pnlConectado.Location = new System.Drawing.Point(144, 12);
            this.pnlConectado.Name = "pnlConectado";
            this.pnlConectado.Size = new System.Drawing.Size(294, 89);
            this.pnlConectado.TabIndex = 6;
            // 
            // lblMejorPuntajeEditar
            // 
            this.lblMejorPuntajeEditar.AutoSize = true;
            this.lblMejorPuntajeEditar.Location = new System.Drawing.Point(87, 53);
            this.lblMejorPuntajeEditar.Name = "lblMejorPuntajeEditar";
            this.lblMejorPuntajeEditar.Size = new System.Drawing.Size(35, 13);
            this.lblMejorPuntajeEditar.TabIndex = 7;
            this.lblMejorPuntajeEditar.Text = "label6";
            // 
            // lblVidaEditar
            // 
            this.lblVidaEditar.AutoSize = true;
            this.lblVidaEditar.Location = new System.Drawing.Point(87, 36);
            this.lblVidaEditar.Name = "lblVidaEditar";
            this.lblVidaEditar.Size = new System.Drawing.Size(35, 13);
            this.lblVidaEditar.TabIndex = 6;
            this.lblVidaEditar.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mejor Puntaje: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vida: ";
            // 
            // lblUsuarioEditar
            // 
            this.lblUsuarioEditar.AutoSize = true;
            this.lblUsuarioEditar.Location = new System.Drawing.Point(87, 18);
            this.lblUsuarioEditar.Name = "lblUsuarioEditar";
            this.lblUsuarioEditar.Size = new System.Drawing.Size(36, 13);
            this.lblUsuarioEditar.TabIndex = 3;
            this.lblUsuarioEditar.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(195, 62);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(87, 23);
            this.btnDesconectar.TabIndex = 0;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnCargarJuego
            // 
            this.btnCargarJuego.Location = new System.Drawing.Point(12, 143);
            this.btnCargarJuego.Name = "btnCargarJuego";
            this.btnCargarJuego.Size = new System.Drawing.Size(140, 30);
            this.btnCargarJuego.TabIndex = 7;
            this.btnCargarJuego.Text = "Cargar Juego";
            this.btnCargarJuego.UseVisualStyleBackColor = true;
            this.btnCargarJuego.Click += new System.EventHandler(this.btnCargarJuego_Click);
            // 
            // VistaMainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.main_fondo;
            this.ClientSize = new System.Drawing.Size(450, 304);
            this.Controls.Add(this.btnCargarJuego);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnConfiguracion);
            this.Controls.Add(this.BtnCargarHistorial);
            this.Controls.Add(this.BtnNuevoJuego);
            this.Controls.Add(this.pnlDesconectado);
            this.Controls.Add(this.pnlConectado);
            this.Name = "VistaMainProgram";
            this.Text = "Juego";
            this.pnlDesconectado.ResumeLayout(false);
            this.pnlDesconectado.PerformLayout();
            this.pnlConectado.ResumeLayout(false);
            this.pnlConectado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoJuego;
        private System.Windows.Forms.Button BtnCargarHistorial;
        private System.Windows.Forms.Button BtnConfiguracion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel pnlDesconectado;
        private System.Windows.Forms.Button BtnCrearCuenta;
        private System.Windows.Forms.TextBox TxtContrasenia;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Panel pnlConectado;
        private System.Windows.Forms.Label lblMejorPuntajeEditar;
        private System.Windows.Forms.Label lblVidaEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuarioEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnCargarJuego;
    }
}

