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
        [MaxLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombre { get; set; }
    }
}