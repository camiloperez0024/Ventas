using System.ComponentModel.DataAnnotations;

namespace Ventas.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Departamento/Estado")] // es para que al usuario le salga el name en español
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")] // la cantidad maxima de caracteres del campo
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] // que no puede ser un campo null en la base de datos
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
