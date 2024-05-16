using gestorGimnasios.Models;

namespace gestorGimnasios.Views
{
    public class GestionandoResponsableView
    {
        private List<Responsable> listaResponsable;

        public List<Responsable> ListaResponsable { get { return this.listaResponsable; } set { this.listaResponsable = value; } }

        public void VisualizarResponsablesRegistrados() { }
        public void RegistrarResponsables() { }
        public void EliminarResponsable() { }
        public void ModificarResponsable() { }

    }
}
