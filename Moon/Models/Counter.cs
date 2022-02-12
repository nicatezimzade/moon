using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Models
{
    public class Counter
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int StartNum { get; set; }
        public int EndNum { get; set; }
        public int Interval { get; set; }
        public int InnerNum { get; set; }
        public string Title { get; set; }

    }
}
