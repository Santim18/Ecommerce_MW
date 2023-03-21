using System.ComponentModel.DataAnnotations;

namespace EcommerceMW.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de creacion")]
        public DateTime? CreatedDate { get; set; } //When is created register en BD, it shows when it was created
        [Display(Name = "Fecha de modificacion")]
        public DateTime? ModifiedDate { get; set; }
    }
}
