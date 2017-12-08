using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class forumtopic
    {
        public int id { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public int nbVue { get; set; }
        public string title { get; set; }
        public byte[] user { get; set; }
    }
}
