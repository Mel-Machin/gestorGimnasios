using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateUpdateViews
{
    public class ModificarOCrearTipoMaquinaView
    {
        private int idTipoMaquina;
        private string nombre;
        private TipoMaquina tipoMaquinaAModificar;
        public int IdTipoMaquina { get { return this.idTipoMaquina; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public TipoMaquina TipoMaquinaAModificar { get { return this.tipoMaquinaAModificar; } set { this.tipoMaquinaAModificar = value; } }
   
        public void SetNombre(in string nombre) { }
        public void CrearTipoMaquina() { }
        public void ModificarTipoMaquina() { }
        public void ModificarOCrearTipoMaquina(TipoMaquina tipoMaquinaAModificar) { }
    }
}
