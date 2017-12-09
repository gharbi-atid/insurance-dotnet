using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class evenement
    {
        public int EventID { get; set; }
        public Nullable<System.DateTime> DateDebut { get; set; }
        public Nullable<System.DateTime> DateFin { get; set; }
        public string address { get; set; }
        public int available { get; set; }
        public int booked { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public int places { get; set; }
        public double price { get; set; }
        public string ImageName { get; set; }

    }
}
