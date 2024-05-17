using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaEmpresarial
{
    public class Alumnos
    {
        public string Nombre { get; set; }
        public int Matricula { get; set; }
        public string CorreoElectronico { get; set; }
        public int Semestre { get; set; }
        public string Teléfono { get; set; }

        public Alumnos(){ }

        public Alumnos(string nombre, int matricula, string correoElectronico, int semestre, string teléfono)
        {
            this.Nombre = nombre;
            this.Matricula = matricula;
            this.CorreoElectronico = correoElectronico;
            this.Semestre = semestre;
            this.Teléfono = teléfono;
        }
    }


}

    