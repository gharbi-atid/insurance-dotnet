using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public partial class forumcomment
    {
        public int id { get; set; }
        public string description { get; set; }
        public int? topic_id { get; set; }
        public Nullable<int> user_id { get; set; }
        [ForeignKey("topic_id")]
        public virtual forumtopic topic { get; set; }
    }
}
