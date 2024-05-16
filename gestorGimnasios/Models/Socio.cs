namespace gestorGimnasios.Models
{
    public class Socio
    {
        private int idSocio;
        private string nombre;
        private string tipo;
        private string telefono;
        private string correoElectronico;
        private int idLocal;

        public int IdSocio { get { return this.idSocio; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Tipo { get { return this.tipo; } set { this.tipo = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public string CorreoElectronico { get { return this.correoElectronico; } set { this.correoElectronico = value; } }
        public int IdLocal { get { return this.idLocal; } set { this.idLocal = value; } }

        public Socio()
        {
            
        }

    }
}
