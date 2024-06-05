using Microsoft.Data.SqlClient;

namespace gestorGimnasios.Models.DataObjets.DAO
{
    public class EjercicioRepositorio
    {
        public List<Ejercicio> ObtenerEjerciciosRegistrados() {
            SqlConnection conexion = new Conexion().obtenerConexion();
            conexion.Open();
            string consulta = "SELECT * FROM ejercicios";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector = comando.ExecuteReader();
            List<Ejercicio> ejercicios = new List<Ejercicio>();
            while (lector.Read())
            {

                Ejercicio ejercicio = new Ejercicio();
                ejercicio.IdEjercicio = (int)lector.GetDecimal(0);
                ejercicio.Descripcion = lector.GetString(1);
                ejercicio.IdTipoMaquina = lector.GetInt32(3);
                ejercicios.Add(ejercicio);
                
            }
            conexion.Close();
            return ejercicios;



        }
        public bool RegistrarEjercicio(Ejercicio ejercicio) { return true; }
        public bool EliminarEjercicio(int idEjercicio) {
            SqlConnection conexion = new Conexion().obtenerConexion();
            conexion.Open();
            string consulta = "DELETE from ejercicios WHERE id_ejercicio = @idEjercicio";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            sqlCommand.Parameters.AddWithValue("@idEjercicio", idEjercicio);
            int afectados = sqlCommand.ExecuteNonQuery();
            if (afectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public bool ModificarEjercicio(Ejercicio ejercicio, int idEjercicio) { return false; }
    }
}
