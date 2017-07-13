using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu.Vistas
{
    public partial class VistaNuevoJuego : Form
    {
        public VistaNuevoJuego()
        {
            InitializeComponent();
        }

        private void VolverClick(object sender, EventArgs e)
        {
            Controladores.ControladorNuevoJuego.setVisible(false);
            Controladores.ControladorMainProgram.setVisible(true);
        }

        private void ComenzarClick(object sender, EventArgs e)
        {
            Controladores.ControladorNuevoJuego.controlador.RepresentacionLaberinto = this.rdBtnScheme.Checked;
            Controladores.ControladorNuevoJuego.controlador.DimX = Decimal.ToInt32(this.numDimX.Value);
            Controladores.ControladorNuevoJuego.controlador.DimY = Decimal.ToInt32(this.numDimY.Value);
            Controladores.ControladorNuevoJuego.controlador.Dificultad = Decimal.ToInt32(this.numDificultad.Value);
            Controladores.ControladorNuevoJuego.controlador.Enemigos = this.enemigosCheck.Checked;
            Controladores.ControladorNuevoJuego.controlador.HardCore = this.hardCoreCheck.Checked;
            Controladores.ControladorLaberinto.Run();
            Controladores.ControladorLaberinto.setVisible(true);
        }

        private void rdBtnScheme_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdBtnScheme.Checked)
                this.numDificultad.Enabled = false;
        }

        private void rdBtnProlog_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdBtnProlog.Checked)
                this.numDificultad.Enabled = true;
        }

        
    }
}
