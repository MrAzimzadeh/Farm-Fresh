using farmfresh.Data;
using farmfresh.Models;
using farmfresh.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace farmfresh.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var banner = _context.Banners.ToList();
            var about = _context.Abouts.OrderBy(x=>x.Id).Last();
            var counter = _context.Counters.ToList();
            var services = _context.Services.ToList();
            var feat = _context.Features.ToList();
            var products = _context.Products.ToList();
            var test = _context.Testimonials.ToList();
            var team = _context.Teams.ToList();
            var blog = _context.Blogs.ToList();
            
            HomeVM homeVM = new()
            {
                Banners = banner,
                About = about,
                Counters = counter,
                Services = services,
                Features = feat,
                Products = products,
                Testimonials = test,
                Teams = team,
                Blogs = blog
            };

            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}