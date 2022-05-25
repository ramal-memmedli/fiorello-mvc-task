using Data.DAL;
using Data.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = await _context.Sliders.ToListAsync();
            homeVM.Cards = await _context.Cards.ToListAsync();
            homeVM.About = await _context.About.FirstOrDefaultAsync();
            homeVM.AboutListItems = await _context.AboutListItems.ToListAsync();
            homeVM.Experts = await _context.Experts.ToListAsync();
            homeVM.BlogCards = await _context.BlogCards.ToListAsync();
            homeVM.Testimonials = await _context.Testimonials.ToListAsync();
            homeVM.InstagramPosts = await _context.InstagramPosts.ToListAsync();
            return View(homeVM);
        }
    }
}
