using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SzokoleniaTechniczne2.Cinema.Common.Entities;

namespace SzokoleniaTechniczne2.Cinema.Domain.Entities
{
    [Table("Movies", Schema = "Cinema")]
    public class Movie : BaseEntity
    {
        [MaxLength(256)]
        [Required]
        public string Name { get; protected set; }
        [Range(1888, 2100)]
        public int Year { get; protected set; }
        [Range(1, 600)]
        public int SeanceTeam { get; protected set; }
        public long MovieCategoryId { get; protected set; }

        protected Movie() { }

        public Movie(string name, int year, int seanceTeam, long movieCategoryId)
        {
            Name = name;
            Year = year;
            SeanceTeam = seanceTeam;
            MovieCategoryId = movieCategoryId;
        }

        public MovieCategory MovieCategory { get; protected set; }

        public virtual ICollection<Seance> Seances { get; protected set; }

        public Seance GetSeanceByDateAndRoomId(DateTime date)
        => Seances.SingleOrDefault(x => DateTime.Compare(x.Date, date) == 1);

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetYear(int year)
        {
            Year = year;
        }

        public void SetSeanceTeam(int seanceTeam)
        {
            SeanceTeam = seanceTeam;
        }
    }
}