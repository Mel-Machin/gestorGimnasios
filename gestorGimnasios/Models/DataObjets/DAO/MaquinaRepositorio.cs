namespace gestorGimnasios.Models.DataObjets.DAO
{
    public class MaquinaRepositorio
    {
        public List<Maquina> obtenerMaquinasRegistradas() { return null; }
        public bool registrarMaquina(Maquina maquina) { return true; }
        public bool eliminarMaquina(int idMaquina) { return false; }
        public bool modificarMaquina(Maquina maquina, int idMaquina) { return true; }
    }
}
