using Data.Models;
using System.Collections.Generic;

namespace FrontToBack.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Card> Cards { get; set; }
        public About About { get; set; }
        public List<AboutListItem> AboutListItems { get; set; }
        public List<Expert> Experts { get; set; }
        public List<BlogCard> BlogCards { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<InstagramPost> InstagramPosts { get; set; }
    }
}
