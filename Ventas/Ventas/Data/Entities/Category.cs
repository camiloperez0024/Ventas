using System.ComponentModel.DataAnnotations;

namespace Ventas.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Categoria")] // es para que al usuario le salga el name en español
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")] // la cantidad maxima de caracteres del campo
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] // que no puede ser un campo null en la base de datos
        public string Name { get; set; }
    }
}
