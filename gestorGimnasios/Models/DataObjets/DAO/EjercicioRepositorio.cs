namespace gestorGimnasios.Models.DataObjets.DAO
{
    public class EjercicioRepositorio
    {
        public List<Ejercicio> ObtenerEjerciciosRegistrados() { return null; }
        public bool RegistrarEjercicio(Ejercicio ejercicio) { return true; }
        public bool EliminarEjercicio(int idEjercicio) { return false; }
        public bool ModificarEjercicio(Ejercicio ejercicio, int idEjercicio) { return false; }
    }
}
