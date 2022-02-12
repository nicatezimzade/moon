using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string ImgSrc { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string ButtonText { get; set; }
    }
}
