using System;
using System.Collections.Generic;

namespace UniBlog.Models
{
    public class Area
    {
        public int AreaID { get; set; }
        public string Nome { get; set; }

        public ICollection<Post> Posts{ get; set; }
    }
}
