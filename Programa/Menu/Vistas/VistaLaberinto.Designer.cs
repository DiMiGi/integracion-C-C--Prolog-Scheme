namespace Menu.Vistas
{
    partial class VistaLaberinto
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
            this.panelFondo = new System.Windows.Forms.Panel();
            this.lblPuntajeEdit = new System.Windows.Forms.Label();
            this.btnRendirse = new System.Windows.Forms.Button();
            this.grpPuntaje = new System.Windows.Forms.GroupBox();
            this.grpPuntaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFondo
            // 
            this.panelFondo.BackColor = System.Drawing.SystemColors.Control;
            this.panelFondo.BackgroundImage = global::Menu.Properties.Resources.ImagenBotones;
            this.panelFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFondo.Enabled = false;
            this.panelFondo.Location = new System.Drawing.Point(12, 12);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(472, 266);
            this.panelFondo.TabIndex = 0;
            // 
            // lblPuntajeEdit
            // 
            this.lblPuntajeEdit.AutoSize = true;
            this.lblPuntajeEdit.Location = new System.Drawing.Point(15, 16);
            this.lblPuntajeEdit.Name = "lblPuntajeEdit";
            this.lblPuntajeEdit.Size = new System.Drawing.Size(13, 13);
            this.lblPuntajeEdit.TabIndex = 2;
            this.lblPuntajeEdit.Text = "0";
            // 
            // btnRendirse
            // 
            this.btnRendirse.Location = new System.Drawing.Point(496, 254);
            this.btnRendirse.Name = "btnRendirse";
            this.btnRendirse.Size = new System.Drawing.Size(75, 23);
            this.btnRendirse.TabIndex = 3;
            this.btnRendirse.Text = "Rendirse";
            this.btnRendirse.UseVisualStyleBackColor = true;
            this.btnRendirse.Click += new System.EventHandler(this.btnRendirse_Click);
            this.btnRendirse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaberintoVista_KeyDown);
            // 
            // grpPuntaje
            // 
            this.grpPuntaje.Controls.Add(this.lblPuntajeEdit);
            this.grpPuntaje.Location = new System.Drawing.Point(496, 12);
            this.grpPuntaje.Name = "grpPuntaje";
            this.grpPuntaje.Size = new System.Drawing.Size(64, 36);
            this.grpPuntaje.TabIndex = 5;
            this.grpPuntaje.TabStop = false;
            this.grpPuntaje.Text = "Puntaje";
            // 
            // VistaLaberinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Menu.Properties.Resources.main_fondo;
            this.ClientSize = new System.Drawing.Size(583, 289);
            this.Controls.Add(this.grpPuntaje);
            this.Controls.Add(this.btnRendirse);
            this.Controls.Add(this.panelFondo);
            this.Name = "VistaLaberinto";
            this.Text = "LaberintoVista";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaberintoVista_KeyDown);
            this.grpPuntaje.ResumeLayout(false);
            this.grpPuntaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Label lblPuntajeEdit;
        private System.Windows.Forms.Button btnRendirse;
        private System.Windows.Forms.GroupBox grpPuntaje;
    }
}