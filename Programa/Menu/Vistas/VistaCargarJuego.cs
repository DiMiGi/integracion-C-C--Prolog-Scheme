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
    public partial class VistaCargarJuego : Form
    {
        public VistaCargarJuego()
        {
            InitializeComponent();
        }

        private void VolverClick(object sender, EventArgs e)
        {
            Controladores.ControladorCargarJuego.setVisible(false);
            Controladores.ControladorMainProgram.setVisible(true);
        }
    }
}
