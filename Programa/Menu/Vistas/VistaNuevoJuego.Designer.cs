namespace Menu.Vistas
{
    partial class VistaNuevoJuego
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
            this.dimXLbl = new System.Windows.Forms.Label();
            this.dimYLbl = new System.Windows.Forms.Label();
            this.DimensionesGrupo = new System.Windows.Forms.GroupBox();
            this.numDificultad = new System.Windows.Forms.NumericUpDown();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.numDimY = new System.Windows.Forms.NumericUpDown();
            this.numDimX = new System.Windows.Forms.NumericUpDown();
            this.comenzarBtn = new System.Windows.Forms.Button();
            this.enemigosCheck = new System.Windows.Forms.CheckBox();
            this.hardCoreCheck = new System.Windows.Forms.CheckBox();
            this.rdBtnProlog = new System.Windows.Forms.RadioButton();
            this.rdBtnScheme = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PropiedadesLaberintoGrupo = new System.Windows.Forms.GroupBox();
            this.atrasBtn = new System.Windows.Forms.Button();
            this.DimensionesGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDificultad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDimY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDimX)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PropiedadesLaberintoGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dimXLbl
            // 
            this.dimXLbl.AutoSize = true;
            this.dimXLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dimXLbl.Image = global::Menu.Properties.Resources.ImagenBotones;
            this.dimXLbl.Location = new System.Drawing.Point(21, 21);
            this.dimXLbl.Name = "dimXLbl";
            this.dimXLbl.Size = new System.Drawing.Size(66, 13);
            this.dimXLbl.TabIndex = 2;
            this.dimXLbl.Text = "Dimension X";
            // 
            // dimYLbl
            // 
            this.dimYLbl.AutoSize = true;
            this.dimYLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dimYLbl.Image = global::Menu.Properties.Resources.ImagenBotones;
            this.dimYLbl.Location = new System.Drawing.Point(21, 48);
            this.dimYLbl.Name = "dimYLbl";
            this.dimYLbl.Size = new System.Drawing.Size(66, 13);
            this.dimYLbl.TabIndex = 3;
            this.dimYLbl.Text = "Dimension Y";
            // 
            // DimensionesGrupo
            // 
            this.DimensionesGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.DimensionesGrupo.BackgroundImage = global::Menu.Properties.Resources.ImagenBotones;
            this.DimensionesGrupo.Controls.Add(this.numDificultad);
            this.DimensionesGrupo.Controls.Add(this.lblDificultad);
            this.DimensionesGrupo.Controls.Add(this.numDimY);
            this.DimensionesGrupo.Controls.Add(this.numDimX);
            this.DimensionesGrupo.Controls.Add(this.dimYLbl);
            this.DimensionesGrupo.Controls.Add(this.dimXLbl);
            this.DimensionesGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DimensionesGrupo.Location = new System.Drawing.Point(12, 12);
            this.DimensionesGrupo.Name = "DimensionesGrupo";
            this.DimensionesGrupo.Size = new System.Drawing.Size(146, 107);
            this.DimensionesGrupo.TabIndex = 4;
            this.DimensionesGrupo.TabStop = false;
            this.DimensionesGrupo.Text = "Dimensiones Laberinto";
            // 
            // numDificultad
            // 
            this.numDificultad.Enabled = false;
            this.numDificultad.Location = new System.Drawing.Point(93, 72);
            this.numDificultad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDificultad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDificultad.Name = "numDificultad";
            this.numDificultad.Size = new System.Drawing.Size(36, 20);
            this.numDificultad.TabIndex = 9;
            this.numDificultad.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDificultad.Image = global::Menu.Properties.Resources.ImagenBotones;
            this.lblDificultad.Location = new System.Drawing.Point(21, 74);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(51, 13);
            this.lblDificultad.TabIndex = 8;
            this.lblDificultad.Text = "Dificultad";
            // 
            // numDimY
            // 
            this.numDimY.Location = new System.Drawing.Point(93, 46);
            this.numDimY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDimY.Name = "numDimY";
            this.numDimY.Size = new System.Drawing.Size(36, 20);
            this.numDimY.TabIndex = 7;
            this.numDimY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numDimX
            // 
            this.numDimX.Location = new System.Drawing.Point(93, 19);
            this.numDimX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDimX.Name = "numDimX";
            this.numDimX.Size = new System.Drawing.Size(36, 20);
            this.numDimX.TabIndex = 6;
            this.numDimX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comenzarBtn
            // 
            this.comenzarBtn.Image = global::Menu.Properties.Resources.ImagenBotones;
            this.comenzarBtn.Location = new System.Drawing.Point(232, 239);
            this.comenzarBtn.Name = "comenzarBtn";
            this.comenzarBtn.Size = new System.Drawing.Size(140, 30);
            this.comenzarBtn.TabIndex = 5;
            this.comenzarBtn.Text = "Comenzar";
            this.comenzarBtn.UseVisualStyleBackColor = true;
            this.comenzarBtn.Click += new System.EventHandler(this.ComenzarClick);
            // 
            // enemigosCheck
            // 
            this.enemigosCheck.AutoSize = true;
            this.enemigosCheck.BackColor = System.Drawing.SystemColors.Window;
            this.enemigosCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enemigosCheck.Location = new System.Drawing.Point(22, 20);
            this.enemigosCheck.Name = "enemigosCheck";
            this.enemigosCheck.Size = new System.Drawing.Size(72, 17);
            this.enemigosCheck.TabIndex = 6;
            this.enemigosCheck.Text = "Enemigos";
            this.enemigosCheck.UseVisualStyleBackColor = false;
            // 
            // hardCoreCheck
            // 
            this.hardCoreCheck.AutoSize = true;
            this.hardCoreCheck.BackColor = System.Drawing.SystemColors.Window;
            this.hardCoreCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hardCoreCheck.Location = new System.Drawing.Point(22, 47);
            this.hardCoreCheck.Name = "hardCoreCheck";
            this.hardCoreCheck.Size = new System.Drawing.Size(74, 17);
            this.hardCoreCheck.TabIndex = 7;
            this.hardCoreCheck.Text = "Hard Core";
            this.hardCoreCheck.UseVisualStyleBackColor = false;
            // 
            // rdBtnProlog
            // 
            this.rdBtnProlog.AutoSize = true;
            this.rdBtnProlog.BackColor = System.Drawing.SystemColors.Window;
            this.rdBtnProlog.Location = new System.Drawing.Point(7, 42);
            this.rdBtnProlog.Name = "rdBtnProlog";
            this.rdBtnProlog.Size = new System.Drawing.Size(122, 17);
            this.rdBtnProlog.TabIndex = 8;
            this.rdBtnProlog.Text = "Laberinto Prologiano";
            this.rdBtnProlog.UseVisualStyleBackColor = false;
            this.rdBtnProlog.CheckedChanged += new System.EventHandler(this.rdBtnProlog_CheckedChanged);
            // 
            // rdBtnScheme
            // 
            this.rdBtnScheme.AutoSize = true;
            this.rdBtnScheme.BackColor = System.Drawing.SystemColors.Window;
            this.rdBtnScheme.Checked = true;
            this.rdBtnScheme.Location = new System.Drawing.Point(7, 19);
            this.rdBtnScheme.Name = "rdBtnScheme";
            this.rdBtnScheme.Size = new System.Drawing.Size(122, 17);
            this.rdBtnScheme.TabIndex = 9;
            this.rdBtnScheme.TabStop = true;
            this.rdBtnScheme.Text = "Laberinto Schemario";
            this.rdBtnScheme.UseVisualStyleBackColor = false;
            this.rdBtnScheme.CheckedChanged += new System.EventHandler(this.rdBtnScheme_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.BackgroundImage = global::Menu.Properties.Resources.ImagenBotones;
            this.groupBox1.Controls.Add(this.rdBtnScheme);
            this.groupBox1.Controls.Add(this.rdBtnProlog);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 73);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PropiedadesLaberintoGrupo
            // 
            this.PropiedadesLaberintoGrupo.BackColor = System.Drawing.SystemColors.Window;
            this.PropiedadesLaberintoGrupo.BackgroundImage = global::Menu.Properties.Resources.ImagenBotones;
            this.PropiedadesLaberintoGrupo.Controls.Add(this.enemigosCheck);
            this.PropiedadesLaberintoGrupo.Controls.Add(this.hardCoreCheck);
            this.PropiedadesLaberintoGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PropiedadesLaberintoGrupo.Location = new System.Drawing.Point(210, 12);
            this.PropiedadesLaberintoGrupo.Name = "PropiedadesLaberintoGrupo";
            this.PropiedadesLaberintoGrupo.Size = new System.Drawing.Size(162, 77);
            this.PropiedadesLaberintoGrupo.TabIndex = 11;
            this.PropiedadesLaberintoGrupo.TabStop = false;
            this.PropiedadesLaberintoGrupo.Text = "Propiedades";
            // 
            // atrasBtn
            // 
            this.atrasBtn.Image = global::Menu.Properties.Resources.ImagenBotones;
            this.atrasBtn.Location = new System.Drawing.Point(86, 239);
            this.atrasBtn.Name = "atrasBtn";
            this.atrasBtn.Size = new System.Drawing.Size(140, 30);
            this.atrasBtn.TabIndex = 12;
            this.atrasBtn.Text = "Volver";
            this.atrasBtn.UseVisualStyleBackColor = true;
            this.atrasBtn.Click += new System.EventHandler(this.VolverClick);
            // 
            // VistaNuevoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.main_fondo;
            this.ClientSize = new System.Drawing.Size(384, 279);
            this.Controls.Add(this.atrasBtn);
            this.Controls.Add(this.PropiedadesLaberintoGrupo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comenzarBtn);
            this.Controls.Add(this.DimensionesGrupo);
            this.Name = "VistaNuevoJuego";
            this.Text = "Nuevo Juego";
            this.DimensionesGrupo.ResumeLayout(false);
            this.DimensionesGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDificultad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDimY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDimX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PropiedadesLaberintoGrupo.ResumeLayout(false);
            this.PropiedadesLaberintoGrupo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dimXLbl;
        private System.Windows.Forms.Label dimYLbl;
        private System.Windows.Forms.GroupBox DimensionesGrupo;
        private System.Windows.Forms.NumericUpDown numDimY;
        private System.Windows.Forms.NumericUpDown numDimX;
        private System.Windows.Forms.Button comenzarBtn;
        private System.Windows.Forms.CheckBox enemigosCheck;
        private System.Windows.Forms.CheckBox hardCoreCheck;
        private System.Windows.Forms.RadioButton rdBtnProlog;
        private System.Windows.Forms.RadioButton rdBtnScheme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox PropiedadesLaberintoGrupo;
        private System.Windows.Forms.Button atrasBtn;
        private System.Windows.Forms.NumericUpDown numDificultad;
        private System.Windows.Forms.Label lblDificultad;
    }
}