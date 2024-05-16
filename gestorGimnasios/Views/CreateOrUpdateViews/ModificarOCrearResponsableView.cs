using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateUpdateViews
{
    public class ModificarOCrearResponsableView
    {

        private int idResponsable;
        private string nombre;
        private string telefono;
        private Responsable responsableAModificar;
        public int IdResponsable { get { return this.idResponsable; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public Responsable ResponsableAModificar { get { return this.responsableAModificar; } set { this.responsableAModificar = value; } }

        public void SetNombre(string nombre) { }
        public void SetTelefono(string telefono) { }
        public void CrearResponsable() { }
        public void ModificarResponsable() { }
        public void ModificarOCrearResponsable(Responsable responsableAModificar) { }
    }
}
