using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvaluacionAprendizaje.Models;
using EvaluacionAprendizaje.Services;

namespace EvaluacionAprendizaje.Controllers
{
    public class CompetidoresController : Controller
    {
        evaluacion2Entities context;
        public CompetidoresController()
        {
            context = new evaluacion2Entities();
        }

        // GET: Competidores
        public ActionResult Index()
        {
            return RedirectToAction("ListaCompetidores");
        }

        public ActionResult ListaCompetidores()
        {
            CompetidoresService competidoresService = new CompetidoresService(context);

            List<Competidor> competidores = competidoresService.ObtenerTodos();

            ViewBag.competidores = competidores;

            return View();
        }

        public ActionResult AltaCompetidor()
        {
            return View();
        }

        public ActionResult RealizarAltaCompetidor(string nombreCompetidor)
        {
            CompetidoresService competidoresService = new CompetidoresService(context);

            competidoresService.AltaCompetidor(nombreCompetidor);

            return RedirectToAction("Index");

        }
    }
}