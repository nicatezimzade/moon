using Microsoft.EntityFrameworkCore;
using Moon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Counter> Counters { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatWrapper> FeatWrappers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<FootMedia> FootMedias { get; set; }










    }
}
