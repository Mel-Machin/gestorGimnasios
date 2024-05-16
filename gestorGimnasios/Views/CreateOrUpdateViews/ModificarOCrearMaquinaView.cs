using gestorGimnasios.Models;

namespace gestorGimnasios.Views.CreateUpdateViews
{
    public class ModificarOCrearMaquinaView
    {
        private int idMaquina;
        private int idLocal;
        private DateTime fechaCompra;
        private decimal precio;
        private int vidaUtil;
        private int idTipoMaquina;
        private string disponibilidad;
        private Maquina maquinaAModificar;

        public int IdMaquina { get { return this.idMaquina; } }
        public int IdLocal { get { return this.idLocal; } set { this.idLocal = value; } }
        public DateTime FechaCompra { get { return this.fechaCompra; } set { this.fechaCompra = value; } }
        public decimal Precio { get { return this.precio; } set { this.precio = value; } }
        public int VidaUtil { get { return this.vidaUtil; } set { this.vidaUtil = value; } }
        public int IdTipoMaquina { get { return this.idTipoMaquina; } set { this.idTipoMaquina = value; } }
        public string Disponibilidad { get { return this.disponibilidad; } set { this.disponibilidad = value; } }
        public Maquina MaquinaAModificar { get { return this.maquinaAModificar; } set { this.maquinaAModificar = value; } }

        public void SetIdLocal(in int idLocal) { }
        public void SetFechaCompra(in DateTime fechaCompra) { }
        public void SetPrecio(in double precio) { }
        public void SetVidaUtil(in int vidaUtil) { }
        public void SetIdTipoMaquina(in int idTipoMaquina) { }
        public void SetDisponibilidad(in string disponibilidad) { }
        public void CrearMaquina() { }
        public void ModificarMaquina() { }
        public void ModificarOCrearMaquina(Maquina maquinaAModificar) { }

    }
}
