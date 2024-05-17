using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstanciaEmpresarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 MenuPrincial = new Form2();
            string usuario, contraseña;

            usuario = txtUsuario.Text;
            contraseña = txtContraseña.Text;

            if (usuario == "ADMIN" && contraseña == "ADMIN")
            {
                this.Hide();
                MenuPrincial.Show();
                
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO!!");
                txtUsuario.Clear();
                txtContraseña.Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
