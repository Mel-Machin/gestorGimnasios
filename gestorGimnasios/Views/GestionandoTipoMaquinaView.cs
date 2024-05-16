using gestorGimnasios.Models;

namespace gestorGimnasios.Views
{
    public class GestionandoTipoMaquinaView
    {
        private List<TipoMaquina> listaTiposMaquinas;

        public List<TipoMaquina> ListaTiposMaquinas { get{ return this.listaTiposMaquinas; } set{ this.listaTiposMaquinas = value; } }

        public void VisualizarTiposMaquinasRegistradas() { }
        public void RegistrarTipoMaquina() { }
        public void EliminarTipoMaquina() { }
        public void ModificarTipoMaquina() { }

    }
}
