using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class reunion_user
    {
        public int Reunion_idReunion { get; set; }
        public int listInvitedEmployees_cin { get; set; }
        public int listReunions_idReunion { get; set; }
        public int listInvitedEmployees_id { get; set; }
    }
}
