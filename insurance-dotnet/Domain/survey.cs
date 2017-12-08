using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class survey
    {
        public int idSurvey { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public string status { get; set; }
    }
}
