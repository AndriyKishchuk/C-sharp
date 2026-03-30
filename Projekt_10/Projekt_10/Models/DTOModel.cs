using System.ComponentModel.DataAnnotations;

namespace Projekt_10.Models
{
    public class DTOModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? CustomerName { get; set; }

        [Required]
        [StringLength(200)]
        public string? Product { get; set; }

        [Range(1, 1000)]
        public int Quantity { get; set; }
    }
}
