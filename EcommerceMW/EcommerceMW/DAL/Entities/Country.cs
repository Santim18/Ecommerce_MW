using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EcommerceMW.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "Pais")]
        [MaxLength(10, ErrorMessage = "El campo {0} debe ser de {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Name { get; set; }


    }
}
