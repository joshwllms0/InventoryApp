using System.ComponentModel.DataAnnotations;

namespace InventoryApp.Models
{
    public class Product
    {
        public int Id {  get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(100)]
        public string SKU { get; set; } = string.Empty;
        [Required]
        [Range(0.01,100000)]
        public decimal Price { get; set; }
        [Required]
        [Range(0,1000)]
        public int Stock { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;
    }
}
