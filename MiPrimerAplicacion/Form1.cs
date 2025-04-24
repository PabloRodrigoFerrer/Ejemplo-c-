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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau..");

        }

        private void Form1_Click(object sender, EventArgs e) 
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo, Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton derecho, Atención");
            else
                MessageBox.Show("Presiono el boton del medio, Atención");

        }


        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento click, Atención");
            //this.BackColor = Color.LightCoral;
            if (txtControl.Text == "")
                txtControl.BackColor = Color.LightCoral;
            else
                txtControl.BackColor = System.Drawing.SystemColors.Control;           
        }

        private void lblUno_MouseMove(object sender, MouseEventArgs e)
        {
            lblUno.BackColor = Color.Cyan;
            lblUno.Cursor = Cursors.Hand;
                            
        }

        private void lblUno_MouseLeave(object sender, EventArgs e)
        {
            lblUno.BackColor = System.Drawing.SystemColors.Control;
            lblUno.Cursor = Cursors.Arrow;

        }

        private void txtControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNombre.Text.Length + " caracteres");
        }
    }

}
