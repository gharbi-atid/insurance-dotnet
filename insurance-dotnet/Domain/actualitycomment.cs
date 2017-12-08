using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class actualitycomment
    {
        public int idActualityComment { get; set; }
        public Nullable<int> actuality_idActuality { get; set; }
        public Nullable<int> insured_cin { get; set; }
        public Nullable<int> insured_id { get; set; }
    }
}
