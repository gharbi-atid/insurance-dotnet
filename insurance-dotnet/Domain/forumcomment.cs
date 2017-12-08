using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class forumcomment
    {
        public int id { get; set; }
        public string description { get; set; }
        public Nullable<int> topic_id { get; set; }
        public Nullable<int> user_id { get; set; }
    }
}
