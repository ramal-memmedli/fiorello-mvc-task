using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AboutListItem> AboutListItems { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<BlogCard> BlogCards { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<InstagramPost> InstagramPosts { get; set; }
    }
}
