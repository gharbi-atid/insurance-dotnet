using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reunion
    {
        public int idReunion { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Nullable<int> employee_cin { get; set; }
        public string mailTo { get; set; }
    }
}
