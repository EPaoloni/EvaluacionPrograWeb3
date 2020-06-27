using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EvaluacionAprendizaje.Models;
using EvaluacionAprendizaje.Services;

namespace EvaluacionAprendizaje.Controllers
{
    public class PremiosController : Controller
    {
        evaluacion2Entities context;
        public PremiosController()
        {
            context = new evaluacion2Entities();
        }

        // GET: Competidores
        public ActionResult Index()
        {
            return RedirectToAction("ListaPremios");
        }

        public ActionResult ListaPremios()
        {
            PremiosService premiosService = new PremiosService(context);
            CompetidoresService competidoresService = new CompetidoresService(context);

            List<PremiosCompetidor> premios = premiosService.ObtenerTodos();

            List<Competidor> competidores = competidoresService.ObtenerTodos();

            List<PremioViewModel> premiosViewModel = PopulatePremiosViewModel(premios, competidores);

            ViewBag.premios = premiosViewModel;

            return View();
        }

        private List<PremioViewModel> PopulatePremiosViewModel(List<PremiosCompetidor> premios, List<Competidor> competidores)
        {
            List<PremioViewModel> premiosViewModel = new List<PremioViewModel>();

            foreach(PremiosCompetidor premio in premios)
            {
                PremioViewModel premioViewModel = new PremioViewModel();
                premioViewModel.anio = premio.anio;
                premioViewModel.cantidadPremios = premio.cantidadPremios;

                string nombreCompetidor = competidores.First(competidor => competidor.id == premio.idCompetidor).nombre;

                premioViewModel.nombreCompetidor = nombreCompetidor;

                premiosViewModel.Add(premioViewModel);
            }

            return premiosViewModel;
        }

    }
}