using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SzokoleniaTechniczne2.Cinema.Common.Entities;

namespace SzokoleniaTechniczne2.Cinema.Domain.Entities
{
    [Table("Tickets", Schema = "Cinema")]
    public class Ticket:BaseEntity
    {
        [MaxLength(256)]
        [Required]
        public string Email { get; protected set; }

        [Range(1, 100)]
        public int PeopleCount { get; protected set; }

        public long SeanceId { get; protected set; }
        public Seance Seance { get; protected set; }

        protected Ticket() { }

        public Ticket(string email, int peopleCount, long seanceId)
        {
            Email = email;
            PeopleCount = peopleCount;
            SeanceId = seanceId;
            CreatedOn = DateTime.UtcNow;
        }
    }
}
