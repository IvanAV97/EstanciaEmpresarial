using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaEmpresarial
{
    public class EstanciaEmpresarial
    {
        public static SqlConnection Obtenerconexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EstanciaEmpresarial;Data Source=DESKTOP-PGS8GBU");
            conexion.Open();
            return conexion;
        }


    }
}
