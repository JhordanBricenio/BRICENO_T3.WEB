using APELLIDO_T3.WEB.Models;
using APELLIDO_T3.WEB.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APELLIDO_T3.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHistoriaRepositorio _historiaRepositorio;

        public HomeController (IHistoriaRepositorio historiaRepositorio)
        {
            _historiaRepositorio = historiaRepositorio;
        }

        public IActionResult Index()
        {
           var historia= _historiaRepositorio.ObtenerTodos();

            return View(historia);
        }
        public IActionResult Create(HistoriaClinica historia)
        {
            if(historia.FechaRegistro<= DateTime.Now)
            {
                ModelState.AddModelError("FechaRegistro", "Fecha de Registro No válido");
            }
            if (historia.FechaNacimiento <= DateTime.Now)
            {
                ModelState.AddModelError("FechaNacimineto", "Fecha de Nacimineto No válido");
            }

            _historiaRepositorio.Agregar(historia);
            TempData["SuccessMessage"] = "Se añádio el Registro de forma correcta";
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}