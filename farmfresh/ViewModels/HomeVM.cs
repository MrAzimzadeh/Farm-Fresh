using farmfresh.Models;

namespace farmfresh.ViewModels
{
    public class HomeVM
    {
        public List<Banner> Banners { get; set; }
        public About About { get; set; }
        public List<Counter> Counters { get; set; }
        public List<Service> Services { get; set; }
        public List<Features> Features { get; set; }
        public List<Products> Products { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Team> Teams { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}