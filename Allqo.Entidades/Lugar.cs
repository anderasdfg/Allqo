using System.ComponentModel.DataAnnotations;

namespace Allqo.Entidades
{
    public class Lugar
    {

        public int idLugar { get; set; }
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "El nombre de la categoría no debe tener más de 15 caracteres, ni menos de 5 caracteres")]
        public string nombre { get; set; }
        [StringLength(400)]
        public float agregado { get; set; }
        
    }
}
