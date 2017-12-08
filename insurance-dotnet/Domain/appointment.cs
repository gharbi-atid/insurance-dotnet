using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class appointment
    {
        public int idAppointment { get; set; }
        public Nullable<int> employee_cin { get; set; }
        public Nullable<int> insured_cin { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> insured_id { get; set; }
    }
}
