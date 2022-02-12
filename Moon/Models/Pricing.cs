using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string PTag { get; set; }
        public int PCapacity { get; set; }
        public string PCapType { get; set; }
        public string PTitle { get; set; }
        public string PFeat1 { get; set; }
        public string PFeat2 { get; set; }
        public string PFeat3 { get; set; }
        public string PFeat4 { get; set; }
        public string PFeat5 { get; set; }
        public string PCost { get; set; }
        public string PDate { get; set; }
        public string PBtnText { get; set; }
        public string PColor { get; set; }

    }
}
