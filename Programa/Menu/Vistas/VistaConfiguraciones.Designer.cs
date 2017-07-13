namespace Menu.Vistas
{
    partial class VistaConfiguraciones
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
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.GrupoResolucion = new System.Windows.Forms.GroupBox();
            this.BoxResoluciones = new System.Windows.Forms.ComboBox();
            this.BoxConfigModo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArriba = new System.Windows.Forms.TextBox();
            this.TxtAbajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDerecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIzquierda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrupoTeclado = new System.Windows.Forms.GroupBox();
            this.GrupoMouse = new System.Windows.Forms.GroupBox();
            this.btnAtaque = new System.Windows.Forms.Button();
            this.lblAtacar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnConfiguracionMouse = new System.Windows.Forms.Button();
            this.GrupoResolucion.SuspendLayout();
            this.GrupoTeclado.SuspendLayout();
            this.GrupoMouse.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.Location = new System.Drawing.Point(100, 262);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(140, 30);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "Volver";
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Click += new System.EventHandler(this.VolverClick);
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Location = new System.Drawing.Point(246, 262);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(140, 30);
            this.BtnAplicar.TabIndex = 1;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.aplicarBtn_Click);
            // 
            // GrupoResolucion
            // 
            this.GrupoResolucion.Controls.Add(this.BoxResoluciones);
            this.GrupoResolucion.Location = new System.Drawing.Point(12, 12);
            this.GrupoResolucion.Name = "GrupoResolucion";
            this.GrupoResolucion.Size = new System.Drawing.Size(374, 44);
            this.GrupoResolucion.TabIndex = 3;
            this.GrupoResolucion.TabStop = false;
            this.GrupoResolucion.Text = "Resolucion";
            // 
            // BoxResoluciones
            // 
            this.BoxResoluciones.FormattingEnabled = true;
            this.BoxResoluciones.Location = new System.Drawing.Point(6, 17);
            this.BoxResoluciones.Name = "BoxResoluciones";
            this.BoxResoluciones.Size = new System.Drawing.Size(362, 21);
            this.BoxResoluciones.TabIndex = 0;
            // 
            // BoxConfigModo
            // 
            this.BoxConfigModo.FormattingEnabled = true;
            this.BoxConfigModo.Items.AddRange(new object[] {
            "Teclado",
            "Mouse"});
            this.BoxConfigModo.Location = new System.Drawing.Point(18, 62);
            this.BoxConfigModo.Name = "BoxConfigModo";
            this.BoxConfigModo.Size = new System.Drawing.Size(168, 21);
            this.BoxConfigModo.TabIndex = 1;
            this.BoxConfigModo.SelectedIndexChanged += new System.EventHandler(this.BoxConfigModo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Arriba";
            // 
            // txtArriba
            // 
            this.txtArriba.Location = new System.Drawing.Point(64, 13);
            this.txtArriba.MaxLength = 1;
            this.txtArriba.Name = "txtArriba";
            this.txtArriba.Size = new System.Drawing.Size(19, 20);
            this.txtArriba.TabIndex = 2;
            this.txtArriba.Text = "W";
            this.txtArriba.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtArriba_MouseClick);
            // 
            // TxtAbajo
            // 
            this.TxtAbajo.Location = new System.Drawing.Point(64, 39);
            this.TxtAbajo.MaxLength = 1;
            this.TxtAbajo.Name = "TxtAbajo";
            this.TxtAbajo.Size = new System.Drawing.Size(19, 20);
            this.TxtAbajo.TabIndex = 6;
            this.TxtAbajo.Text = "S";
            this.TxtAbajo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtAbajo_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Abajo";
            // 
            // TxtDerecha
            // 
            this.TxtDerecha.Location = new System.Drawing.Point(64, 65);
            this.TxtDerecha.MaxLength = 1;
            this.TxtDerecha.Name = "TxtDerecha";
            this.TxtDerecha.Size = new System.Drawing.Size(19, 20);
            this.TxtDerecha.TabIndex = 8;
            this.TxtDerecha.Text = "D";
            this.TxtDerecha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtDerecha_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Derecha";
            // 
            // TxtIzquierda
            // 
            this.TxtIzquierda.Location = new System.Drawing.Point(64, 91);
            this.TxtIzquierda.MaxLength = 1;
            this.TxtIzquierda.Name = "TxtIzquierda";
            this.TxtIzquierda.Size = new System.Drawing.Size(19, 20);
            this.TxtIzquierda.TabIndex = 10;
            this.TxtIzquierda.Text = "A";
            this.TxtIzquierda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtIzquierda_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Izquierda";
            // 
            // GrupoTeclado
            // 
            this.GrupoTeclado.Controls.Add(this.label1);
            this.GrupoTeclado.Controls.Add(this.TxtIzquierda);
            this.GrupoTeclado.Controls.Add(this.txtArriba);
            this.GrupoTeclado.Controls.Add(this.label4);
            this.GrupoTeclado.Controls.Add(this.label2);
            this.GrupoTeclado.Controls.Add(this.TxtDerecha);
            this.GrupoTeclado.Controls.Add(this.TxtAbajo);
            this.GrupoTeclado.Controls.Add(this.label3);
            this.GrupoTeclado.Location = new System.Drawing.Point(12, 89);
            this.GrupoTeclado.Name = "GrupoTeclado";
            this.GrupoTeclado.Size = new System.Drawing.Size(100, 124);
            this.GrupoTeclado.TabIndex = 12;
            this.GrupoTeclado.TabStop = false;
            // 
            // GrupoMouse
            // 
            this.GrupoMouse.Controls.Add(this.btnAtaque);
            this.GrupoMouse.Controls.Add(this.lblAtacar);
            this.GrupoMouse.Controls.Add(this.label5);
            this.GrupoMouse.Controls.Add(this.BtnConfiguracionMouse);
            this.GrupoMouse.Location = new System.Drawing.Point(158, 100);
            this.GrupoMouse.Name = "GrupoMouse";
            this.GrupoMouse.Size = new System.Drawing.Size(200, 100);
            this.GrupoMouse.TabIndex = 13;
            this.GrupoMouse.TabStop = false;
            this.GrupoMouse.Visible = false;
            // 
            // btnAtaque
            // 
            this.btnAtaque.Location = new System.Drawing.Point(59, 40);
            this.btnAtaque.Name = "btnAtaque";
            this.btnAtaque.Size = new System.Drawing.Size(99, 23);
            this.btnAtaque.TabIndex = 3;
            this.btnAtaque.Text = "Left";
            this.btnAtaque.UseVisualStyleBackColor = true;
            this.btnAtaque.Click += new System.EventHandler(this.btnAtaque_Click);
            // 
            // lblAtacar
            // 
            this.lblAtacar.AutoSize = true;
            this.lblAtacar.Location = new System.Drawing.Point(6, 45);
            this.lblAtacar.Name = "lblAtacar";
            this.lblAtacar.Size = new System.Drawing.Size(47, 13);
            this.lblAtacar.TabIndex = 2;
            this.lblAtacar.Text = "Ataque: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Moverse: ";
            // 
            // BtnConfiguracionMouse
            // 
            this.BtnConfiguracionMouse.Location = new System.Drawing.Point(59, 11);
            this.BtnConfiguracionMouse.Name = "BtnConfiguracionMouse";
            this.BtnConfiguracionMouse.Size = new System.Drawing.Size(99, 23);
            this.BtnConfiguracionMouse.TabIndex = 0;
            this.BtnConfiguracionMouse.Text = "Right";
            this.BtnConfiguracionMouse.UseVisualStyleBackColor = true;
            this.BtnConfiguracionMouse.Click += new System.EventHandler(this.BtnConfiguracionMouse_Click);
            // 
            // VistaConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.main_fondo;
            this.ClientSize = new System.Drawing.Size(398, 304);
            this.Controls.Add(this.GrupoMouse);
            this.Controls.Add(this.GrupoTeclado);
            this.Controls.Add(this.BoxConfigModo);
            this.Controls.Add(this.GrupoResolucion);
            this.Controls.Add(this.BtnAplicar);
            this.Controls.Add(this.BtnVolver);
            this.Name = "VistaConfiguraciones";
            this.Text = "ConfiguracionesVista";
            this.GrupoResolucion.ResumeLayout(false);
            this.GrupoTeclado.ResumeLayout(false);
            this.GrupoTeclado.PerformLayout();
            this.GrupoMouse.ResumeLayout(false);
            this.GrupoMouse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.GroupBox GrupoResolucion;
        private System.Windows.Forms.ComboBox BoxResoluciones;
        private System.Windows.Forms.ComboBox BoxConfigModo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArriba;
        private System.Windows.Forms.TextBox TxtAbajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDerecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIzquierda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrupoTeclado;
        private System.Windows.Forms.GroupBox GrupoMouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnConfiguracionMouse;
        private System.Windows.Forms.Button btnAtaque;
        private System.Windows.Forms.Label lblAtacar;
    }
}