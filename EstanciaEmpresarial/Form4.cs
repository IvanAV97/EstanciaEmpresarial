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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estancia estancia = new Estancia();
            estancia.Nombre_Empresa = txtNombre_Empresa.Text;
            estancia.Proyecto = TxtProyecto.Text;
            estancia.Fecha_Inicio = dtp_Finicio.Text;
            estancia.Fecha_Final = dtpFfin.Text;
            estancia.Responsable = txtResponsable.Text;
            estancia.Direccion_Empresa = txtDireccionEmpresa.Text;
            estancia.RFC = txtRFC.Text;


            int result = EstanciaDal.AgregarEstancia(estancia);
            if (result > 0)
            {
                MessageBox.Show("Estancia Guardada con exito!!");
                txtNombre_Empresa.Clear();
                TxtProyecto.Clear();
                txtResponsable.Clear();
                txtDireccionEmpresa.Clear();
                txtRFC.Clear();
                
            }
            else
            {
                MessageBox.Show("Fallo al Guardar!!");
            }
        }
    }
}
