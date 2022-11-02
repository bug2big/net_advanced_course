using System.ComponentModel.DataAnnotations;

namespace net_advanced_course.DAL.Entities
{
    public class Cart : BaseEntity
    {
        [Required]
        public string Name { get; set; } = null!;

        public string? Image { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
