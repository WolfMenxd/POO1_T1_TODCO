using Microsoft.AspNetCore.Mvc;
using POO1_T1_TODCO.Models;

namespace POO1_T1_TODCO.Controllers
{
    public class AdministrativoController : Controller
    {
        [HttpGet]
        public IActionResult RegistrarAdministrativo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarAdministrativo(Administrativo administrativo)
        {
            double sueldoBasico = administrativo.SueldoBasico();
            double escolaridad = administrativo.Escolaridad();
            double bonificacion = administrativo.Bonificacion();
            double incentivo = administrativo.Incentivo();
            double montoAPagar = administrativo.MontoAPagar();

            ViewBag.SueldoBasico = sueldoBasico;
            ViewBag.Escolaridad = escolaridad;
            ViewBag.Bonificacion = bonificacion;
            ViewBag.Incentivo = incentivo;
            ViewBag.MontoAPagar = montoAPagar;

            return View("ResultadoAdministrativo", administrativo);
        }
    }
}