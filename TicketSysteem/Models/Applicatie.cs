using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Applicatie
    {
        public Medewerker Beheerder { get; set; }
        public int Id { get; set; }
        public string Naam { get; set; }
    }
}
