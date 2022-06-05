using Data.DAL;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public ProductsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take, int skip = 0)
        {
            List<Product> products = await _context.Products.Where(n => !n.IsDeleted)
                                                  .Include(n => n.Category)
                                                  .Include(n => n.ProductImages)
                                                  .ThenInclude(n => n.Image)
                                                  .Skip(skip)
                                                  .Take(take).ToListAsync();

            return View(products);
        }
    }
}
