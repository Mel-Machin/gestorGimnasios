using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace gestorGimnasios.Models.DataObjets.DAO
{
    public class Conexion
    {

        public SqlConnection obtenerConexion()
        {
            string datosConexion = @"Data Source=ELBRUJOAQUINO\SQLEXPRESS;Initial Catalog=Gym24;Integrated Security=True;Encrypt=False;";

            SqlConnection conexion = new SqlConnection(datosConexion);
            return conexion;
        }
    }
}
