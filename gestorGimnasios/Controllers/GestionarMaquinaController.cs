using gestorGimnasios.Models;

namespace gestorGimnasios.Controllers
{
    public class GestionarMaquinaController
    {
        public List<Maquina> obtenerMaquinasRegistradas() { return null; }
        public bool registrarMaquina(Maquina maquina) { return true; }
        public bool eliminarMaquina(int idMaquina) { return false; }
        public bool modificarMaquina(Maquina maquina, int idMaquina) { return true; }
        public List<Maquina> ObtenerMaquinasPorLocal(Local local) { return null; }
    }
}
