using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class user
    {
        public string USER_TYPE { get; set; }
        public int id { get; set; }
        public string Adresse { get; set; }
        public string FirstName { get; set; }
        public int Tel { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string confrimPassword { get; set; }
        public string lastName { get; set; }
        public string login { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string photo { get; set; }
        public string role { get; set; }
        public string sex { get; set; }
        public Nullable<System.DateTime> dateOfContract { get; set; }
        public Nullable<System.DateTime> dateOfHire { get; set; }
        public string Diplome { get; set; }
        public string statut { get; set; }
    }
}
