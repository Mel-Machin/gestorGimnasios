using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateOrUpdateViews
{
    public class ModificarOCrearEjercicioView
    {
        private int idEjercicio;
        private string descripcion;
        private int idTipoMaquina;
        private Ejercicio ejercicioAModificar;
        public int IdEjercicio { get { return this.idEjercicio; } set { this.idEjercicio = value; } }
        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
        public int IdTipoMaquina { get { return this.idTipoMaquina; } set { this.idTipoMaquina = value; } }
        public Ejercicio EjercicioAModificar { get { return this.ejercicioAModificar; } set { this.ejercicioAModificar = value; } }

        public void SetDescripcion(string descripcion) { }
        public void SetIdTipoMaquina(int idTipoMaquina) { }
        public void CrearEjercicio() { }
        public void ModificarEjercicio() { }
        public ModificarOCrearEjercicioView(Ejercicio ejercicioAModificar){}


    }
}
