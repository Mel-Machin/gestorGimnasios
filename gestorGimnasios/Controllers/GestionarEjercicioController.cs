using gestorGimnasios.Models;
using gestorGimnasios.Models.DataObjets.DAO;

namespace gestorGimnasios.Controllers
{
    public class GestionarEjercicioController
    {
        public List<Ejercicio> ObtenerEjerciciosRegistrados()
        {
            return new EjercicioRepositorio().ObtenerEjerciciosRegistrados();
        }
        
        public bool RegistrarEjercicio(Ejercicio ejercicio) { return true; }
        public bool EliminarEjercicio(int idEjercicio) {
            return new EjercicioRepositorio().EliminarEjercicio(idEjercicio);
          }
        public bool ModificarEjercicio(Ejercicio ejercicio,int idEjercicio) { return false; }
    }
}
