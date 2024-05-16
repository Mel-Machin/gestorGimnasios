using gestorGimnasios.Models;

namespace gestorGimnasios.Views
{
    public class GestionandoMaquinaView
    {
        private List<Maquina> listaMaquinas;

        public List<Maquina> ListaMaquinas { get { return this.listaMaquinas; } set { this.listaMaquinas = value; } }

        public void VisualizarMaquinasRegistradas() { }
        public void RegistrarMaquina() { }
        public void EliminarMaquina() { }
        public void ModificarMaquina() { }

        public void CalcularVidaUtil(Maquina maquina) { }
        public void FiltrarPorFechaCompra(DateTime fechaCompra) { }

    }
}
