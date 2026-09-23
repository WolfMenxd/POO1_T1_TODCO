using Microsoft.AspNetCore.Mvc;
using POO1_T1_TODCO.Models;

namespace POO1_T1_TODCO.Controllers
{
    public class EmpleadoController : Controller
    {
        public static List<Empleado> Colaboradores = new List<Empleado>
        {
            new Empleado
            {
                IdEmpleado = "E001",
                NomapeEmpleado = "Juan Perez",
                CategoriaEmpleado = "E1",
                NHijos = 2,
                TipoContrato = "Indefinido"
            },

            new Empleado
            {
                IdEmpleado = "E002",
                NomapeEmpleado = "Maria Lopez",
                CategoriaEmpleado = "E2",
                NHijos = 1,
                TipoContrato = "Contratado"
            },

            new Empleado
            {
                IdEmpleado = "E003",
                NomapeEmpleado = "Carlos Diaz",
                CategoriaEmpleado = "E3",
                NHijos = 3,
                TipoContrato = "Indefinido"
            },

            new Empleado
            {
                IdEmpleado = "E004",
                NomapeEmpleado = "Ana Torres",
                CategoriaEmpleado = "E4",
                NHijos = 0,
                TipoContrato = "Contratado"
            }
        };

        public IActionResult Index()
        {
            return View(Colaboradores);
        }

        [HttpGet]
        public IActionResult RegistrarEmpleado()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarEmpleado(Empleado empleado)
        {
            Colaboradores.Add(empleado);

            ViewBag.SueldoBasico = empleado.SueldoBasico();
            ViewBag.Escolaridad = empleado.Escolaridad();
            ViewBag.Bonificacion = empleado.Bonificacion();
            ViewBag.MontoAPagar = empleado.MontoAPagar();

            return View("ResultadoEmpleado", empleado);
        }
    }
}