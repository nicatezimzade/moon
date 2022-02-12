using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moon.DAL;
using Moon.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Moon.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;

        public HomeController(AppDbContext db)
        {
            dbContext = db;
        }


        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                banners = dbContext.Banners.ToList(),
                hero = dbContext.Heroes.FirstOrDefault(),
                counters = dbContext.Counters.ToList(),
                features = dbContext.Features.ToList(),
                featwrappers = dbContext.FeatWrappers.ToList(),
                blogs = dbContext.Blogs.ToList(),
                projects = dbContext.Projects.ToList(),
                categories = dbContext.Categories.ToList(),
                pricings = dbContext.Pricings.ToList(),
                clients = dbContext.Clients.ToList(),
                footmedias = dbContext.FootMedias.ToList(),
            };

            return View(hvm);
        }

    }
}
