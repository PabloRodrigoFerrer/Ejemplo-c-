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
            // Le agrego un comentario al archivo ... 
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
                txtApellido.ForeColor = Color.White;
                todoValido = false;
            }

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.LightCoral;
                txtNombre.ForeColor = Color.White;
                todoValido = false;
            }

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.LightCoral;
                txtEdad.ForeColor = Color.White;
                todoValido = false;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.LightCoral;
                txtDireccion.ForeColor = Color.White;
                todoValido = false;
            }

            if (!todoValido)
            {
                MessageBox.Show("Ingrese todos los datos solicitados" ,"Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            string mensaje = $"Apellido y Nombre: {txtApellido.Text}, {txtNombre.Text} \r\n" +
                             $"Edad: {txtEdad.Text}\r\n" +
                             $"Direccion: {txtDireccion.Text}";

            txtResultado.Text = mensaje;

            MessageBox.Show("Carga de datos exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void FormularioDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
