using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rentacar.domain.entity
{
    public class BookingEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }

        [ForeignKey("CarEntity")]
        public int CarId { get; set; }

        public bool IsActive { get; set; }
    }
}
