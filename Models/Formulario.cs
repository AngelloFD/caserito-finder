using System.ComponentModel.DataAnnotations;

namespace caserito_finder.Models
{
    public partial class Formulario
    {
        [Required(ErrorMessage = "ID Requerido")]
        public string IdForm { get; set; } = null!;
        
        [Required(ErrorMessage = "Nombre Requerido")]
        public string? negoNom { get; set; }
        
        [Required(ErrorMessage = "Dueño Requerido")]
        public string? negoDue { get; set; }
        
        [Required(ErrorMessage = "Dirección Requerida")]
        public string? negoDir { get; set; }
        
        [Required(ErrorMessage = "Email Requerido")]
        public string? negoEmail { get; set; }

        [Required(ErrorMessage = "Teléfono Requerido")]
        public string? negoTelf { get; set; }
        
        public string? negoHIni { get; set; }
        public string? negoHEnd { get; set; }
    }
}
