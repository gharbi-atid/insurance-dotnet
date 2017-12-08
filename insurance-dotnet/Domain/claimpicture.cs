using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class claimpicture
    {
        public string name { get; set; }
        public byte[] url { get; set; }
        public Nullable<int> claim_idClaim { get; set; }
    }
}
