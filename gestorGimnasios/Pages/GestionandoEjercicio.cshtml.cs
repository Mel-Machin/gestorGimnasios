using gestorGimnasios.Controllers;
using gestorGimnasios.Models;
using gestorGimnasios.Models.DataObjets.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace gestorGimnasios.Pages
{
    public class GestionandoEjercicioModel : PageModel
    {
        public List<Ejercicio> Ejercicios { get; set; }
        public void OnGet()
        {
            Ejercicios = this.obtenerEjecicios();
        }

        private List<Ejercicio> obtenerEjecicios()
        {
            GestionarEjercicioController gestionarEjercicioController = new GestionarEjercicioController();
            return gestionarEjercicioController.ObtenerEjerciciosRegistrados();
        }

        public bool eliminarEjercicio(int id_Ejercicio)
        {
            GestionarEjercicioController gestionarEjercicioController = new GestionarEjercicioController();
            return gestionarEjercicioController.EliminarEjercicio(id_Ejercicio);
        }
    
    }
}
