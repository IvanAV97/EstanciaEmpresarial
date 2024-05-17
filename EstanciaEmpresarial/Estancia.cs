using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaEmpresarial
{
    public class Estancia
    {
        public string Nombre_Empresa { get; set; }
        public string Proyecto { get; set; }
        public string Fecha_Inicio { get; set; }
        public string Fecha_Final { get; set; }
        public string Responsable { get; set; }
        public string Direccion_Empresa { get; set; }
        public string RFC { get; set; }


        public Estancia() { }

        public Estancia(string nombre_Empresa, string proyecto, string fecha_Inicio, string fecha_Final, string responsable, string direccion_Empresa, string rFC)
        {
            Nombre_Empresa = nombre_Empresa;
            Proyecto = proyecto;
            Fecha_Inicio = fecha_Inicio;
            Fecha_Final = fecha_Final;
            Responsable = responsable;
            Direccion_Empresa = direccion_Empresa;
            RFC = rFC;
        }
    }
}
