using gestorGimnasios.Models;

namespace gestorGimnasios.Controllers
{
    public class GestionarRutinaController
    {
        public List<Rutina> ObtenerRutinasResgistradas() { return null; }
        public bool RegistrarRutina(in Rutina rutina) { return false; }
        public bool EliminarRutina(in int idRutina) { return true; }
        public bool ModificarRutina(in Rutina rutina, in int idRutina) { return false; }
    }
}
