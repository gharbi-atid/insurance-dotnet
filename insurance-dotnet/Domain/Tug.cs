using Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Tug
    {
        [Key]
        public int idTug { get; set; }
        [Display(Name ="Matricule")]
        [DataType(DataType.Text)]
        public string reference { get; set; }
        [Display(Name = "Zone")]
        [DataType(DataType.Text)]
        public string zone { get; set; }
        [Display(Name = "Start Work Date")]
        [DataType(DataType.Date, ErrorMessage = "Date non valid")]
        public DateTime startDate { get; set; }
        [Display(Name = "End Work Date")]
        [DataType(DataType.Date, ErrorMessage = "Date non valid")]
        public DateTime endDate { get; set; }
        [Display(Name = "Type")]
        [DataType(DataType.Text)]
        public string type { get; set; }
        [Display(Name = "Statut")]
        [DataType(DataType.Text)]
        public string status { get; set; }
        [Display(Name = "Prix")]
        [DataType(DataType.Text)]
        public int price { get; set; }
        [ForeignKey("car")]
        public int idCar { get; set; }
        public virtual car car { get; set; } 
    }
}
