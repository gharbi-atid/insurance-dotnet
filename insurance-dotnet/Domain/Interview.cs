using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Interview
    {
        public int id { get; set; }
        public DateTime dateInterview { get; set; }
        public user idstagiaire { get; set; }
        public string experience { get; set; }
        public string diplome { get; set; }
        public string motivations { get; set; }
    }
}
