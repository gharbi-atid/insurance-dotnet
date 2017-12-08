using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class estimation
    {
        public int id { get; set; }
        public float Painting { get; set; }
        public float SheetMetalWorkshop { get; set; }
        public float Woodwork { get; set; }
        public float electricity { get; set; }
        public float mechanical { get; set; }
        public float priceWorkForce { get; set; }
        public string result { get; set; }
        public float tapestry { get; set; }
        public float valueAfter { get; set; }
        public float valueBefore { get; set; }
        public float valueClam { get; set; }
    }
}
