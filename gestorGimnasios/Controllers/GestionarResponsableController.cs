using gestorGimnasios.Models;

namespace gestorGimnasios.Controllers
{
    public class GestionarResponsableController
    {
        public List<Responsable> obtenerResponsablesRegistrados() { return null; }
        public bool registrarResponsable(Responsable responsable) { return true; }
        public bool modificarResponsable(Responsable responsable, int idResponsable) { return true; }
        public bool eliminarResponsable(int idResponsable) { return true; }
    }
}