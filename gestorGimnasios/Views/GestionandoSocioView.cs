using gestorGimnasios.Models;

namespace gestorGimnasios.Views
{
    public class GestionandoSocioView
    {
        private List<Socio> listaSocios;

        public List<Socio> ListaSocio { get { return this.listaSocios; } set { this.listaSocios = value; } }

        public void VisualizarSociosRegistrados() { }
        public void RegistrarSocio() { }
        public void EliminarSocio() { }
        public void ModificarSocio() { }
        public void FiltrarSocioPorTipo(string tipo) { }

    }
}
