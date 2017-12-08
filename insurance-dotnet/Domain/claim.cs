using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class claim
    {
        public int idClaim { get; set; }
        public bool Injury { get; set; }
        public string damagePostion { get; set; }
        public bool damageToOtherProperty { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string description { get; set; }
        public int nbCar { get; set; }
        public byte[] picture { get; set; }
        public string place { get; set; }
        public string status { get; set; }
        public string title { get; set; }
        public Nullable<int> contract_refContract { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> estimation_id { get; set; }
        public byte[] Circumstances { get; set; }
        public string image { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
