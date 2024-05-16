namespace gestorGimnasios.Models.DataObjets.DAO
{
    public class TipoMaquinaRepositorio
    {

        public List<TipoMaquina> obtenerTiposMaquinasRegistradas() { return null; }
        public bool registrarTipoMaquina(TipoMaquina tipoMaquina) { return true; }
        public bool eliminarTipoMaquina(int idTipoMaquina) { return false; }
        public bool modificarTipoMaquina(TipoMaquina tipoMaquina, int idTipoMaquina) { return true; }
    }
}
