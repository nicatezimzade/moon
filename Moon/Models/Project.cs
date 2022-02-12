using Moon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Moon.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ProjectIcon1 { get; set; }
        public string ProjectIcon2 { get; set; }
        public string Subtitle { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
