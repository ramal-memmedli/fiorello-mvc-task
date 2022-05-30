using Data.DAL;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products
                                    .Where(n => !n.IsDeleted)
                                    .Include(n => n.ProductImages)
                                    .ThenInclude(n => n.Image)
                                    .Include(n => n.Category)
                                    .ToListAsync();

            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            Product product = await _context.Products
                                    .Where(n => !n.IsDeleted && n.Id == id)
                                    .Include(n => n.ProductImages)
                                    .ThenInclude(n => n.Image)
                                    .Include(n => n.Category)
                                    .FirstOrDefaultAsync();

            if (product is null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult> Create()
        {
            ViewData["Categories"] = await GetCategories();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            Image image = await _context.Images.Where(n => n.Name == product.ImageUrl).FirstOrDefaultAsync();
            if(image is null)
            {
                return NotFound();
            }

            product.CreatedDate = DateTime.Now;

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            ProductImages productImages = new ProductImages();
            productImages.ProductId = product.Id;
            productImages.ImageId = image.Id;

            await _context.ProductImages.AddAsync(productImages);
            await _context.SaveChangesAsync();


            return RedirectToAction(actionName: nameof(Index), controllerName: nameof(Product));
        }

        public async Task<IActionResult> Update(int id)
        {
            Product product = await _context.Products
                                    .Where(n => !n.IsDeleted && n.Id == id)
                                    .Include(n => n.ProductImages)
                                    .ThenInclude(n => n.Image)
                                    .Include(n => n.Category)
                                    .FirstOrDefaultAsync();

            if(product is null)
            {
                return NotFound();
            }

            ViewData["Categories"] = await GetCategories();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Product product)
        {
            Product dbProduct = await _context.Products
                                    .Where(n => !n.IsDeleted && n.Id == id)
                                    .Include(n => n.ProductImages)
                                    .ThenInclude(n => n.Image)
                                    .Include(n => n.Category)
                                    .FirstOrDefaultAsync();

            if (product is null)
            {
                return NotFound();
            }

            ProductImages productImages = await _context.ProductImages.Where(n => n.ProductId == dbProduct.Id).FirstOrDefaultAsync();
            Image image = await _context.Images.Where(n => n.Name == product.ImageUrl).FirstOrDefaultAsync();

            if (productImages is null || image is null)
            {
                return NotFound();
            }

            productImages.ImageId = image.Id;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.Title = product.Title;
            dbProduct.Price = product.Price;

            _context.Products.Update(dbProduct);
            _context.ProductImages.Update(productImages);
            await _context.SaveChangesAsync();

            return RedirectToAction(actionName: nameof(Index), controllerName: nameof(Product));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Product product = await _context.Products.Where(n => !n.IsDeleted && n.Id == id).FirstOrDefaultAsync();

            if (product is null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Product product)
        {
            Product dbProduct = await _context.Products.Where(n => !n.IsDeleted && n.Id == product.Id).FirstOrDefaultAsync();

            if (product is null)
            {
                return NotFound();
            }

            if (product.Title.Trim() == dbProduct.Title)
            {
                dbProduct.IsDeleted = true;
                _context.Products.Update(dbProduct);
                await _context.SaveChangesAsync();
            }
            else
            {
                return Content("Delete operation cancelled. Because entered product name is wrong.");
            }

            return RedirectToAction(actionName: nameof(Index), controllerName: nameof(Product));
        }

        private async Task<List<Category>> GetCategories()
        {
            List<Category> categories = await _context.Categories.Where(n => !n.IsDeleted).ToListAsync();
            return categories;
        }
    }
}
