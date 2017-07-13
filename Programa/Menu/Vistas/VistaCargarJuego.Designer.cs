namespace Menu.Vistas
{
    partial class VistaCargarJuego
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
            this.VolverBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(86, 239);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(140, 30);
            this.VolverBtn.TabIndex = 0;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cargar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // VistaCargarJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.main_fondo;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.VolverBtn);
            this.Name = "VistaCargarJuego";
            this.Text = "CargarJuegoVista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button button2;
    }
}