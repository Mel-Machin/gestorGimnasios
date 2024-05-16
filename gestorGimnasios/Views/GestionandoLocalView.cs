using gestorGimnasios.Models;
using System.Security.AccessControl;

namespace gestorGimnasios.Views
{
    public class GestionandoLocalView
    {

        private List<Local> listaLocales;
        private List<Maquina> listaMaquinas;

        public List<Local> ListaLocales { get { return this.listaLocales; } set { this.listaLocales = value; } }
        public List<Maquina> ListaMaquinas { get { return this.listaMaquinas; } set { this.listaMaquinas = value; } }

        public void VisualizarLocalesRegistrados() { }
        public void RegistrarLocal() { }
        public void EliminarLocal() { }
        public void ModificarLocal() { }


    }
}
