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
            List<PremiosCompetidor> premios = context.PremiosCompetidor.ToList();
            return premios;
        }

        public void AltaPremios(int idCompetidor, int anio, int cantidadPremios)
        {
            PremiosCompetidor premiosDelMismoAnio = context.PremiosCompetidor.FirstOrDefault(premios => premios.idCompetidor == idCompetidor && premios.anio == anio);

            if(premiosDelMismoAnio == null)
            {
                PremiosCompetidor nuevoPremiosCompetidor = new PremiosCompetidor();
                nuevoPremiosCompetidor.idCompetidor = idCompetidor;
                nuevoPremiosCompetidor.anio = anio;
                nuevoPremiosCompetidor.cantidadPremios = cantidadPremios;

                context.PremiosCompetidor.Add(nuevoPremiosCompetidor);
            } else
            {
                premiosDelMismoAnio.cantidadPremios = cantidadPremios;
            }

            context.SaveChanges();
        }

        public int CalcularTotalPremiosPorAnio(int anio)
        {
            try
            {
                return context.PremiosCompetidor.Where(premios => premios.anio == anio).Sum(element => element.cantidadPremios);
            }
            catch (Exception e)
            {
                return 0;
            }
            


        }
    }
}