using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace caserito_finder.Models
{
    public partial class Form
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre del negocio es OBLIGATORIO")]
        public string? NombreNegocio { get; set; }
        [Required(ErrorMessage = "El campo Dueño del negocio es OBLIGATORIO")]
        public string? DueñoNegocio { get; set; }
        [Required(ErrorMessage = "El campo Direccion es OBLIGATORIO")]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "El campo E-mail es OBLIGATORIO")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "El campo Telefono es OBLIGATORIO")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Desde es OBLIGATORIO")]
        public int? Desde { get; set; }
        [Required(ErrorMessage = "El campo Hasta es OBLIGATORIO")]
        public int? Hasta { get; set; }
    }
}
