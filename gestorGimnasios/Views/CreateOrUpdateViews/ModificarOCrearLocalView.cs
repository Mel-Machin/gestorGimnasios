using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateUpdateViews
{
    public class ModificarOCrearLocalView
    {

        private int idLocal;
        private string nombre;
        private string ciudad;
        private string direccion;
        private string telefono;
        private int  idResponsable;
        private Local localAModificar;

        public int IdLocal { get { return this.idLocal; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Ciudad { get { return this.ciudad; } set { this.ciudad = value; } }
        public string Direccion { get { return this.direccion; } set { this.direccion = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public int IdResponsable { get { return this.idResponsable; } set { this.idResponsable = value; } }
        public Local LocalAModificar { get { return this.localAModificar; } set { this.localAModificar = value; } }

        public void SetNombre(string nombre) { }
        public void SetCiudad(string ciudad) { }
        public void SetDireccion(string direccion) { }
        public void SetTelefono(string telefono) { }
        public void SetIdResponsable( int idResponsable) { }
        public void CrearLocal() { }
        public void MoficiarLocal() { }
        public void ModificaroCrearLocalView(Local localAModificar) { }

    }
}
