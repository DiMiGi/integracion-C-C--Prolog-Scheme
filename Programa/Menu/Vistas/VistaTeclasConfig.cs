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
    public partial class VistaTeclasConfig : Form
    {
        public VistaTeclasConfig()
        {
            InitializeComponent();
        }

        private void VistaTeclasConfig_MouseClick(object sender, MouseEventArgs e)
        {
            //Controladores.ControladorTeclasConfig.controlador.KeyPress = false;
            Controladores.ControladorTeclasConfig.controlador.mouseClose(e);
            Controladores.ControladorTeclasConfig.setVisible(false);
        }


        public void setText()
        {
            this.lblTextoPresion.Size = new Size(this.Size.Width/4,this.Size.Height/8);
            this.lblTextoPresion.Location = new Point(this.Location.X+10, this.Location.Y+100);
        }

        private void VistaTeclasConfig_KeyDown(object sender, KeyEventArgs e)
        {
            Controladores.ControladorTeclasConfig.controlador.keyClose(e);
            Controladores.ControladorTeclasConfig.setVisible(false);
        }
    }
}
