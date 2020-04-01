using Microsoft.EntityFrameworkCore;

namespace TicketSysteem.Models
{
    public class TicketContext : DbContext
    {

        /// <param name="options">De opties, zoals database connection</param>
        public TicketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Applicatie> Applicaties { get; set; }

        public DbSet<Gebruiker> Gebruiker { get; set; }

        public DbSet<Klant> Klanten { get; set; }

        public DbSet<Medewerker> Medewerkers { get; set; }

        public DbSet<Status> Statussen { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

    }
}