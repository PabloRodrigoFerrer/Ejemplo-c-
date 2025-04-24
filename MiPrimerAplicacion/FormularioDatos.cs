using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class FormularioDatos : Form
    {
        public FormularioDatos()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtApellido.BackColor = SystemColors.Window;
            txtNombre.BackColor = SystemColors.Window;
            txtEdad.BackColor = SystemColors.Window;
            txtDireccion.BackColor = SystemColors.Window;

            bool todoValido = true;

            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.LightCoral;
                todoValido = false;
            }

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.LightCoral;
                todoValido = false;
            }

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.LightCoral;
                todoValido = false;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.LightCoral;
                todoValido = false;
            }

            if (!todoValido)
                return;



            string mensaje = $"Apellido y Nombre: {txtApellido.Text}, {txtNombre.Text} \r\n" +
                             $"Edad: {txtEdad.Text}\r\n" +
                             $"Direccion: {txtDireccion.Text}";

            txtResultado.Text = mensaje;

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
