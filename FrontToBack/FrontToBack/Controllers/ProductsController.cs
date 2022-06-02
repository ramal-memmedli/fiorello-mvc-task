using Data.DAL;
using Data.Models;
using FrontToBack.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace FrontToBack.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        ProductsVM productsVM = new ProductsVM();

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            

            productsVM.Products = await _context.Products.Where(n => !n.IsDeleted)
                                                  .Include(n => n.Category)
                                                  .Include(n => n.ProductImages)
                                                  .ThenInclude(n => n.Image)
                                                  .Take(4).ToListAsync();

            productsVM.Categories = await _context.Categories.Where(n => !n.IsDeleted).ToListAsync();

            return View(productsVM);
        }

        [Route("{controller}/loadmore/{skip}")]
        public async Task<IActionResult> LoadMore(int skip)
        {
            productsVM.Products = await _context.Products.Where(n => !n.IsDeleted)
                                                  .Include(n => n.Category)
                                                  .Include(n => n.ProductImages)
                                                  .ThenInclude(n => n.Image)
                                                  .Skip(skip)
                                                  .Take(4).ToListAsync();
            return PartialView("_ProductPartial", productsVM);
        }

        public async Task<IActionResult> AllProductCount()
        {
            int productCount = await _context.Products.Where(n => !n.IsDeleted).CountAsync();

            return Json(productCount);
        }

        public IActionResult SetItemIntoBasket(int id)
        {
            List<BasketItemVM> basketItems;
            string cookieString = Request.Cookies["basket"];

            if(string.IsNullOrEmpty(cookieString))
            {
                basketItems = new List<BasketItemVM>();
            }
            else
            {
                basketItems = JsonSerializer.Deserialize<List<BasketItemVM>>(cookieString);
            }

            BasketItemVM basketItem = basketItems.Where(n => n.Id == id).FirstOrDefault();

            if(basketItem is null)
            {
                basketItem = new BasketItemVM();
                basketItem.Id = id;
                basketItem.Count = 1;
                basketItems.Add(basketItem);
            }else
            {
                basketItem.Count++;
            }

            cookieString = JsonSerializer.Serialize(basketItems);

            Response.Cookies.Append("basket", cookieString);

            return Json(new
            {
                status = 200,
                basket = basketItems
            });
        }

        public IActionResult GetItemsFromBasket()
        {
            List<BasketItemVM> basketItems;
            string cookieString = Request.Cookies["basket"];

            if(string.IsNullOrEmpty(cookieString))
            {
                basketItems= new List<BasketItemVM>();
            }else
            {
                basketItems = JsonSerializer.Deserialize<List<BasketItemVM>>(cookieString);
            }

            return Json(new
            {
                status = 200,
                basket = basketItems
            });
        }
    }
}
