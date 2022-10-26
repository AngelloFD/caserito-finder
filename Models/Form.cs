using System;
using System.Collections.Generic;

namespace caserito_finder.Models
{
    public partial class Form
    {
        public int Id { get; set; }
        public string? NombreNegocio { get; set; }
        public string? DueñoNegocio { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public int? Desde { get; set; }
        public int? Hasta { get; set; }
    }
}
