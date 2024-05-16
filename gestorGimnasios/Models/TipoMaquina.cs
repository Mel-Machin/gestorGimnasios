namespace gestorGimnasios.Models
{
    public class TipoMaquina
    {
        private int idTipoMaquina;
        private string nombre;

        public int IdTipoMaquina { get { return this.idTipoMaquina; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }

        public TipoMaquina()
        {
            
        }

    }
}
