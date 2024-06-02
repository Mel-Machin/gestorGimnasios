﻿namespace gestorGimnasios.Models
{
    public class Rutina
    {
        private int idRutina;
        private string descripcion;
        private string tipoRutina;
        private decimal calificacionRutinaPromedio;
        private List<Ejercicio> listaEjercicios;

        public int IDRutina { get { return this.idRutina; } set { this.idRutina = value; } }
        public string Descripcion { get { return this.descripcion; } set {this.descripcion = value; } }
        public string TipoRutina { get { return this.TipoRutina; } set { if (value == "salud" || value == "competencia amateur" || value == "competencia profesional") { this.tipoRutina = value; }; } }
        public decimal CalificacionRutinaPromedio { get{return this.calificacionRutinaPromedio ; }set{this.calificacionRutinaPromedio = value; } }
        public List<Ejercicio> ListaEjercicios { get{ return this.listaEjercicios; }set{ this.listaEjercicios = value; } }
    }
}
