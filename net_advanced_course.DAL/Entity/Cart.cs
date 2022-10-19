using System.ComponentModel.DataAnnotations;

namespace LayeredArchitecturesTest1.DAL.Entity
{
    public class Cart
    {
        [Required()]
        public int Id { get; set; }
        
        [Required()]
        public string Name { get; set; }
        public string? Image { get; set; }

        [Required()]
        public double Price { get; set; }

        [Required()]
        public int Quantity { get; set; }
    }
}
