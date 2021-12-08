using FlowerStore.DAL;
using FlowerStore.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerStore.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public PartialViewResult LoadMore(int skipCount)
        {
            var product = _context.Products.Skip(skipCount).Take(4).Include(p => p.category).ToList();
            return PartialView("_ProductPartial", product);
        }
        
        public IActionResult Index()
        {
            var product = _context.Products.Take(4).Include(a=>a.category).ToList();
            ViewBag.SkipCount = product.Count;
            return View(new ProductViewModel {product=product });
        }
    }
}
