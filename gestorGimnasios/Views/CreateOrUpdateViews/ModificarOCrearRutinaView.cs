using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateOrUpdateViews
{
    public class ModificarOCrearRutinaView
    {
        private int idRutina;
        private string descripcion;
        private string tipoRutina;
        private decimal calificacionRutinaPromedio;
        private List<Ejercicio> listaEjercicios;
        private Rutina rutinaAModificar;
        public int IDRutina { get { return this.idRutina; } set { this.idRutina = value; } }
        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
        public string TipoRutina { get { return this.tipoRutina; } set { if (value == "salud" || value == "competencia amateur" || value == "competencia profesional") { this.tipoRutina = value; }; } }
        public decimal CalificacionRutinaPromedio { get { return this.calificacionRutinaPromedio; } set { this.calificacionRutinaPromedio = value; } }
        public List<Ejercicio> ListaEjercicios { get { return this.listaEjercicios; } set { this.listaEjercicios = value; } }
        public Rutina RutinaAModificar { get {return this.rutinaAModificar; } set {this.rutinaAModificar = value; } }

        public void SetDescripcion(string descripcion) { }
        public void SetTipoRutina(string tipoRutina) { }
        public void SetListaEjercicios(List<Ejercicio> listaEjercicio) { }
        public void CrearRutina() { }
        public void ModificarRutina() { }
        public  ModificarOCrearRutinaView(Rutina rutinaAModificar) { }
    }
}
