using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionAprendizaje.Models.Partials
{
    public partial class Competidor
    {
        [Required(ErrorMessage="Nombre Requerido")]
        [MaxLength(100)]
        public string nombre { get; set; }
    }
}