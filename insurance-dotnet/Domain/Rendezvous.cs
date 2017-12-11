using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Rendezvous
    {
        public int RendezVousId { get; set; }
        public DateTime DateRendezVous { get; set; }
        public string Description { get; set; }
        public string NomAssurance { get; set; }
        public byte[] Insured_cin { get; set; }

        public string oks { get; set; }
    }
}
