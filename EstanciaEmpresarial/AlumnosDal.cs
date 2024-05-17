using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaEmpresarial
{
    public class AlumnosDal
    {

        public static int AgregarAlumno(Alumnos alumnos)
        {
            int retorna = 0;

            using (SqlConnection conexion = EstanciaEmpresarial.Obtenerconexion())
            {
                string query = "insert into Alumnos (Nombre,CorreoElectronico,Semestre,Telefono) values('"+alumnos.Nombre+"','"+alumnos.CorreoElectronico+"', "+alumnos.Semestre+", '"+alumnos.Teléfono+"') ";  
                SqlCommand Comando = new SqlCommand(query,conexion);

                retorna = Comando.ExecuteNonQuery();


            }
            return retorna;

        }
    }
}
