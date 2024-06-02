using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateUpdateViews
{
    public class ModificarOCrearSocioView
    {

        private int idSocio;
        private string nombre;
        private string tipo;
        private string telefono;
        private string correoElectronico;
        private int idLocal;
        private Socio socioAModificar;

        public int IdSocio { get { return this.idSocio; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Tipo { get { return this.tipo; } set { this.tipo = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public string CorreoElectronico { get { return this.correoElectronico; } set { this.correoElectronico = value; } }
        public int IdLocal { get { return this.idLocal; } set { this.idLocal = value; } }
        public Socio SocioAModificar { get{ return this.socioAModificar; } set{ this.socioAModificar = value; } }

        public void SetNombre(in string nombre) { }
        public void SetTipo(in string tipo) { }
        public void SetTelefono(in string telefono) { }
        public void SetCorreoElectronico(in string correoElectronico) { }
        public void SetIdLocal(in int idLocal) { }
        public void CrearSocio() { }
        public void ModificarSocio() { }

        public ModificarOCrearSocioView(Socio socioAModificar)
        {
            
        }
    }
}
