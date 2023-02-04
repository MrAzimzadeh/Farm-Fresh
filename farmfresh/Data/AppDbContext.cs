using farmfresh.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace farmfresh.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Counter> Counters { get; set; }

        public DbSet<Features> Features { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }

    }
}
