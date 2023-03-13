using System.ComponentModel.DataAnnotations;

namespace EcommerceMW.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        public DateTime? CreatedDate { get; set; } //When is created register en BD, it shows when it was created
        public DateTime? ModifiedDate { get; set; }
    }
}
