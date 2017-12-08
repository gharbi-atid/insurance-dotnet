using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class surveyvote
    {
        public int idSurveyVote { get; set; }
        public Nullable<int> insured_cin { get; set; }
        public Nullable<int> survey_idSurvey { get; set; }
        public Nullable<int> insured_id { get; set; }
        public string vote { get; set; }
    }
}
