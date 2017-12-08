using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class car
    {
        public int idCar { get; set; }
        public Nullable<int> contract_refContract { get; set; }
        public string marque { get; set; }
        public string matricule { get; set; }
        public string modele { get; set; }
    }
}
