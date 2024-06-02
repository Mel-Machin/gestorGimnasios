using gestorGimnasios.Models;

namespace gestorGimnasios.Views
{
    public class GestionandoRutinaView
    {
        private List<Rutina> listaRutinas;
        public List<Rutina> ListaRutinas { get { return this.listaRutinas; } set { this.listaRutinas = value; } }

        public void VisualizarRutinasRegistradas() { }
        public void RegistrarRutina() { }
        public void EliminarRutina() { }
        public void ModificarRutina() { }
    }
}
