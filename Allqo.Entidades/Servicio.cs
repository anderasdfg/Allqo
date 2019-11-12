using System.ComponentModel.DataAnnotations;

namespace Allqo.Entidades
{
    public class Servicio
    {
        public int idServicio { get; set; }
        [Required]
        [StringLength(7, MinimumLength = 3, ErrorMessage="El nombre de la categoría no debe tener más de 7 caracteres, ni menos de 3 caracteres")]
        public string categoria { get; set; }
        [StringLength(400)]
        public string descripcion { get; set; }
        [StringLength(400)]
        public float precio { get; set; }
    }
}
