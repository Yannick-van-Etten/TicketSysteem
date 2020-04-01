using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSysteem.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Tussenvoegsels { get; set; }
        public string Achternaam { get; set; }
        public string EmailAdres { get; set; }
        public string Telefoonnummer { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string VolledigeNaam => $"{Voornaam} {Tussenvoegsels} {Achternaam}";
    }
}
