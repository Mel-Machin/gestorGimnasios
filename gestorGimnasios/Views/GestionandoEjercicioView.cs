using gestorGimnasios.Models;

namespace gestorGimnasios.Views
{
    public class GestionandoEjercicioView
    {

        private List<Ejercicio> listaEjercicios;
        public List<Ejercicio> ListaEjercicios { get { return this.listaEjercicios; } set { this.listaEjercicios = value; } }

        public void VisualizarEjerciciosRegistrados() { }
        public void RegistrarEjercicio() { }
        public void EliminarEjercicio() { }
        public void ModificarEjercicio() { }
    }
}
