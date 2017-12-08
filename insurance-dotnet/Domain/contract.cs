using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class contract
    {
        public int refContract { get; set; }
        public Nullable<int> insured_cin { get; set; }
        public Nullable<int> log_idLog { get; set; }
        public Nullable<System.DateTime> creationdate { get; set; }
        public int police { get; set; }
        public Nullable<int> car_idCar { get; set; }
        public Nullable<int> insured_id { get; set; }
    }
}
