﻿namespace gestorGimnasios.Models
{
    public class Responsable
    {
        private int idResponsable;
        private string nombre;
        private string telefono;

        public int IdResponsable { get { return this.idResponsable; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }

        public Responsable()
        {
            
        }

    }
}
