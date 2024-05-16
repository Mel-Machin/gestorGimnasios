using gestorGimnasios.Models;

namespace gestorGimnasios.Controllers
{
    public class GestionarTipoMaquinaController
    {
        public List<TipoMaquina> obtenerTiposMaquinasRegistradas() { return null; }
        public bool registrarTipoMaquina(TipoMaquina tipoMaquina) { return true; }
        public bool eliminarTipoMaquina(int idTipoMaquina) { return false; }
        public bool modificarTipoMaquina(TipoMaquina tipoMaquina, int idTipoMaquina) { return true; }
    }
}
