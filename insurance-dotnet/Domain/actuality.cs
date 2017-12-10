using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class actuality
    {
        public int idActuality { get; set; }

        public string titre { get; set; }

        public string description { get; set; }

        public DateTime date { get; set; }
    }
}
