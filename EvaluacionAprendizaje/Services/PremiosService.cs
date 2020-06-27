using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using EvaluacionAprendizaje.Models;

namespace EvaluacionAprendizaje.Services
{
    public class PremiosService
    {
        evaluacion2Entities context;
        public PremiosService(evaluacion2Entities context)
        {
            this.context = context;
        }

        public List<PremiosCompetidor> ObtenerTodos()
        {
            List<PremiosCompetidor> premios = context.PremiosCompetidor.ToList(); ;
            return premios;
        }

        public void AltaCompetidor(string nombre)
        {
            Competidor nuevoCompetidor = new Competidor();
            nuevoCompetidor.nombre = nombre;

            context.Competidor.Add(nuevoCompetidor);
            
            context.SaveChanges();
        }
    }
}