using gestorGimnasios.Models;

namespace gestorGimnasios.Controllers
{
    public class GestionarEjercicioController
    {
        public List<Ejercicio> ObtenerEjerciciosRegistrados() { return null; }
        public bool RegistrarEjercicio(Ejercicio ejercicio) { return true; }
        public bool EliminarEjercicio(int idEjercicio) { return false; }
        public bool ModificarEjercicio(Ejercicio ejercicio,int idEjercicio) { return false; }
    }
}
