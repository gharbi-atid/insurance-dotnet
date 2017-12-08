using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class testimony
    {
        public int idTestimony { get; set; }
        public string Email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public Nullable<int> claim_idClaim { get; set; }
    }
}
