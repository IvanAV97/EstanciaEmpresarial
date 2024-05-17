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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.Nombre = txtNombreAlumno.Text;
            alumnos.CorreoElectronico = txtCorreoE.Text;
            alumnos.Semestre =Convert.ToInt32(txtSemestre.Text);
            alumnos.Teléfono = txtTelefono.Text;

            int result = AlumnosDal.AgregarAlumno(alumnos);

            if (result > 0)
            {
                MessageBox.Show("Alumno Guardado exitosamente!!");
                txtNombreAlumno.Clear(); 
                txtCorreoE.Clear();
                txtSemestre.Clear();
                txtTelefono.Clear();
            }
            else
            {
                MessageBox.Show("Fallo al Guardar!!");
            }


        }
    }
}
