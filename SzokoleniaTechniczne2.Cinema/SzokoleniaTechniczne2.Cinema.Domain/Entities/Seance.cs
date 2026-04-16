using System.ComponentModel.DataAnnotations.Schema;
using SzokoleniaTechniczne2.Cinema.Common.Entities;

namespace SzokoleniaTechniczne2.Cinema.Domain.Entities
{
    [Table("Seances", Schema = "Cinema")]
    public class Seance : BaseEntity
    {
        public DateTime Date { get; protected set; }
        public long MovieId { get; protected set; }
        public Movie Movie { get; protected set; }

        public virtual ICollection<Ticket> Tickets { get; protected set; } = new HashSet<Ticket>();

        public List<Ticket> GetTicketsByEmail(string email)
        {
            return Tickets.Where(t => t.Email == email).OrderBy(t => t.CreatedOn).ToList();
        }
        public List<Ticket> GetAllSeancesTicket()
        {
            return Tickets == null ? new List<Ticket>() : Tickets.ToList();
        }

        public void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
