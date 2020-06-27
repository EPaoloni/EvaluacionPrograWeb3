using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using EvaluacionAprendizaje.Models;

namespace EvaluacionAprendizaje.Services
{
    public class CompetidoresService
    {
        evaluacion2Entities context;
        public CompetidoresService(evaluacion2Entities context)
        {
            this.context = context;
        }

        public List<Competidor> ObtenerTodos()
        {
            List<Competidor> competidores = context.Competidor.ToList(); ;
            return competidores;
        }

        public void AltaCompetidor(string nombre)
        {
            Competidor nuevoCompetidor = new Competidor();
            nuevoCompetidor.nombre = nombre;

            context.Competidor.Add(nuevoCompetidor);
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}