using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstanciaEmpresarial
{
    public class EstanciaDal
    {

        public static int AgregarEstancia(Estancia estancia)
        {
            int retorna = 0;

            using (SqlConnection conexion = EstanciaEmpresarial.Obtenerconexion())
            {
                string query = "INSERT INTO Estancia (Nombre_Empresa, Proyecto, Fecha_Inicio, Fecha_Fin, Responsable, Direccion_Empresa, RFC) VALUES ('" + estancia.Nombre_Empresa + "','" + estancia.Proyecto + "', '" + estancia.Fecha_Inicio + "', '" + estancia.Fecha_Final + "', '" + estancia.Responsable + "', '" + estancia.Direccion_Empresa + "', '" + estancia.RFC + "');";

                SqlCommand Comando = new SqlCommand(query, conexion);

                retorna = Comando.ExecuteNonQuery();


            }
            return retorna;
        }
    }
}
