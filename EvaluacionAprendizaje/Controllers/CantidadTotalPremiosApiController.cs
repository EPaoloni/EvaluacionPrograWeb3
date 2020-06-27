using EvaluacionAprendizaje.Models;
using EvaluacionAprendizaje.Services;
using System.Web.Http;
using System.Web.Http.Results;

namespace PracticaEA2.Controllers
{
    public class CantidadTotalPremiosApiController : ApiController
    {
        evaluacion2Entities context;

        public CantidadTotalPremiosApiController()
        {
            context = new evaluacion2Entities();
        }

        // GET api/<controller>
        public JsonResult<int> Get(int id)
        {
            PremiosService premiosService = new PremiosService(context);

            int totalDePremios = premiosService.CalcularTotalPremiosPorAnio(id);

            return Json(totalDePremios);
        }

    }
}