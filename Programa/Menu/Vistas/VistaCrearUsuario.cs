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
    public partial class VistaCrearUsuario : Form
    {
        public VistaCrearUsuario()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtJugador.Text.Length >= 4 && TxtJugador.Text.Length <= 32 &&
            TxtUsuario.Text.Length >= 4 && TxtUsuario.Text.Length <= 32)
                if (TxtContra1.Text.Equals(TxtContra2.Text))
                {
                    Controladores.ControladorCrearUsuario.controlador.crearUsuario(TxtUsuario.Text, TxtContra1.Text, TxtJugador.Text);
                    BtnCancelar_Click(null,EventArgs.Empty);
                }
                else
                {
                    //contraseñas no coinciden
                    MessageBox.Show("Las contraseñas no coinciden, por favor vuelva a intentarlo.", "Creacion De Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show("Los campos de usuario y jugador deben tener al menos 4 caracteres y a lo mas 32 caracteres.", "Creacion De Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Largo incorrecto
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Controladores.ControladorMainProgram.setVisible(true);
            Controladores.ControladorCrearUsuario.setVisible(false);
        }

        public void CreacionJugadorMensaje(bool valor)
        {
            if (valor)
                MessageBox.Show("Se ha creado su usuario con exito!.", "Creacion De Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se ha podido crear su usuario con exito.", "Creacion De Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
