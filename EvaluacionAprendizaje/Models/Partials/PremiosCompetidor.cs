using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionAprendizaje.Models.Partials
{
    public partial class PremiosCompetidor
    {
        [Required(ErrorMessage="Competidor Requerido")]
        public int idCompetidor { get; set; }

        [Required(ErrorMessage ="Año requerido")]
        [Range(2011, 2100, ErrorMessage = "El año debe ser mayor a 2010")]
        public int anio { get; set; }

        [Required(ErrorMessage ="Cantidad de premios requerido")]
        [Range(1, 50, ErrorMessage = "La cantidad de premios debe estar entre 1 y 50")]
        public int cantidadPremios { get; set; }
    }
}