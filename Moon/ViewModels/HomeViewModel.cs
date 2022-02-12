using Moon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.ViewModels
{
    public class HomeViewModel
    {
        public List<Banner> banners { get; set; }
        public Hero hero { get; set; }
        public List<Counter> counters { get; set; }
        public List<Feature> features { get; set; }
        public List<FeatWrapper> featwrappers { get; set; }
        public List<Blog> blogs { get; set; }
        public List<Category> categories { get; set; }
        public List<Project> projects { get; set; }
        public List<Pricing> pricings { get; set; }
        public List<Client> clients { get; set; }
        public List<FootMedia> footmedias { get; set; }


    }
}
