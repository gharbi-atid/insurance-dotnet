using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reclamation
    {
        public int idReclamation { get; set; }
        public Nullable<int> insured_cin { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string subject { get; set; }
        public Nullable<int> insured_id { get; set; }
        public Nullable<System.DateTime> dateTime { get; set; }
    }
}
