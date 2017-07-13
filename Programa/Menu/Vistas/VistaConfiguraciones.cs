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
    public partial class VistaConfiguraciones : Form
    {

        

        private int posApretado;

        private bool fue_apretado = false;

        public bool Fue_apretado
        {
            get { return fue_apretado; }
            set { fue_apretado = value; }
        }

        public VistaConfiguraciones()
        {
            InitializeComponent();
            BoxConfigModo.SelectedIndex = 0;
        }


        public void actualizarResoluciones(){
            foreach (Modelos.Resolucion elem in Controladores.ControladorConfiguraciones.controlador.Resoluciones)
            {
                    BoxResoluciones.Items.Add(elem.ToString());
            }
            if(Controladores.ControladorConfiguraciones.controlador.Resoluciones.Count != 0)
                BoxResoluciones.SelectedIndex = 0;
        }

        private void VolverClick(object sender, EventArgs e)
        {
            Controladores.ControladorConfiguraciones.controlador.KeyArriba = Controladores.ControladorConfiguraciones.controlador.KeyArribaDef;
            Controladores.ControladorConfiguraciones.controlador.KeyAbajo = Controladores.ControladorConfiguraciones.controlador.KeyAbajoDef;
            Controladores.ControladorConfiguraciones.controlador.KeyDerecha = Controladores.ControladorConfiguraciones.controlador.KeyDerDef;
            Controladores.ControladorConfiguraciones.controlador.KeyIzquierda = Controladores.ControladorConfiguraciones.controlador.KeyIzqDef;
            Controladores.ControladorConfiguraciones.setVisible(false);
            Controladores.ControladorMainProgram.setVisible(true);
        }

        public void cambiar(MouseEventArgs e){
            if (Fue_apretado && BoxConfigModo.SelectedItem.Equals("Mouse"))
            {
                BtnConfiguracionMouse.Text = e.Button.ToString();
                Fue_apretado = false;
            }
        }

        public void cambiar(KeyEventArgs e)
        {
            if (Fue_apretado && BoxConfigModo.SelectedItem.Equals("Teclado"))
            {
                if (posApretado == 0)
                {
                    txtArriba.Text = e.KeyCode.ToString().ToUpper();
                    Controladores.ControladorConfiguraciones.controlador.KeyArriba = e.KeyCode;
                }
                if (posApretado == 1)
                {
                    TxtAbajo.Text = e.KeyCode.ToString().ToUpper();
                    Controladores.ControladorConfiguraciones.controlador.KeyAbajo = e.KeyCode;
                }
                if (posApretado == 2)
                {
                    TxtIzquierda.Text = e.KeyCode.ToString().ToUpper();
                    Controladores.ControladorConfiguraciones.controlador.KeyIzquierda = e.KeyCode;
                }
                if (posApretado == 3)
                {
                    TxtDerecha.Text = e.KeyCode.ToString().ToUpper();
                    Controladores.ControladorConfiguraciones.controlador.KeyDerecha = e.KeyCode;
                }
                Fue_apretado = false;
            }
        }


        private void aplicarBtn_Click(object sender, EventArgs e)
        {
            if (this.BoxResoluciones.SelectedIndex != Controladores.ControladorConfiguraciones.controlador.ResolucionOriginal)
            {
                Controladores.ControladorConfiguraciones.controlador.ResolucionActual = this.BoxResoluciones.SelectedIndex;
                Controladores.ControladorConfiguraciones.controlador.aplicarDimensiones(true);
                Controladores.ControladorConfiguraciones.controlador.KeyArribaDef = Controladores.ControladorConfiguraciones.controlador.KeyArriba;
                Controladores.ControladorConfiguraciones.controlador.KeyAbajoDef = Controladores.ControladorConfiguraciones.controlador.KeyAbajo;
                Controladores.ControladorConfiguraciones.controlador.KeyIzqDef = Controladores.ControladorConfiguraciones.controlador.KeyIzquierda;
                Controladores.ControladorConfiguraciones.controlador.KeyDerDef = Controladores.ControladorConfiguraciones.controlador.KeyDerecha;
            }
        }

        private void ConfiguracionesVista_MouseClick(object sender, MouseEventArgs e)
        {
            if (Fue_apretado && BoxConfigModo.SelectedItem.Equals("Mouse"))
            {
                BtnConfiguracionMouse.Text = e.Button.ToString();
                Fue_apretado = false;
            }
        }

        private void BtnConfiguracionMouse_Click(object sender, EventArgs e)
        {
            Fue_apretado = true;
            Controladores.ControladorTeclasConfig.controlador.KeyPress = false;
            Controladores.ControladorTeclasConfig.setVisible(true);
        }

        private void btnAtaque_Click(object sender, EventArgs e)
        {
            Fue_apretado = true;
            Controladores.ControladorTeclasConfig.controlador.KeyPress = false;
            Controladores.ControladorTeclasConfig.setVisible(true);
        }

        private void BoxConfigModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.BoxConfigModo.SelectedIndex;
            if (this.BoxConfigModo.Items[index].ToString().Equals("Teclado"))
            {
                this.GrupoMouse.Visible = false;
                this.GrupoTeclado.Visible = true;
            }
            else if (this.BoxConfigModo.Items[index].ToString().Equals("Mouse"))
            {
                this.GrupoMouse.Visible = true;
                this.GrupoTeclado.Visible = false;
            }

        }

        private void txtArriba_MouseClick(object sender, MouseEventArgs e)
        {
            Fue_apretado = true;
            posApretado = 0;
            Controladores.ControladorTeclasConfig.controlador.KeyPress = true;
            Controladores.ControladorTeclasConfig.setVisible(true);
        }

        private void TxtAbajo_MouseClick(object sender, MouseEventArgs e)
        {
            Fue_apretado = true;
            posApretado = 1;
            Controladores.ControladorTeclasConfig.controlador.KeyPress = true;
            Controladores.ControladorTeclasConfig.setVisible(true);
        }

        private void TxtIzquierda_MouseClick(object sender, MouseEventArgs e)
        {
            Fue_apretado = true;
            posApretado = 2;
            Controladores.ControladorTeclasConfig.controlador.KeyPress = true;
            Controladores.ControladorTeclasConfig.setVisible(true);
        }

        private void TxtDerecha_MouseClick(object sender, MouseEventArgs e)
        {
            Fue_apretado = true;
            posApretado = 3;
            Controladores.ControladorTeclasConfig.controlador.KeyPress = true;
            Controladores.ControladorTeclasConfig.setVisible(true);
        }
    }
}
