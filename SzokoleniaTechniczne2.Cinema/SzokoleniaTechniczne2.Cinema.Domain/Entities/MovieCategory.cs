using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SzokoleniaTechniczne2.Cinema.Common.Entities;

namespace SzokoleniaTechniczne2.Cinema.Domain.Entities
{
    [Table("MovieCategories", Schema ="Cinema")]
    public class MovieCategory : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; protected set; }

        public virtual ICollection<Movie> Movies { get; protected set; } = new List<Movie>();

        protected MovieCategory() { }

        public MovieCategory(string name)
        {
            Name = name;
        }
      
    }
}
