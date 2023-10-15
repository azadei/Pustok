using Microsoft.AspNetCore.Mvc;
using Pustok.Database;
using Pustok.Database.DomainModels;
using Pustok.ViewModels;
using System.Linq;

namespace Pustok.Admin
{
    public class AdminController : Controller
    {
        public IActionResult Products()
        {
            DbContext dbContext = new DbContext();
            return View(DbContext._products);
            
        }

        public IActionResult ProductAdd()
        {
           
            return View();

        }

        [HttpPost]
        public IActionResult SubmitProduct(Product product)
        {

            DbContext._products.Add(product);

            return RedirectToAction("Products");
        }

        public IActionResult ProductEdit(int id)
        {
            var product = DbContext._products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }

        public IActionResult EditSubmitProduct(ProductUpdateViewModel model)
        {
            var product = DbContext._products.FirstOrDefault(p => p.Id == model.Id);
            if (product == null)
            {
                return NotFound();
            }

            product.Name = model.Name;
            product.Description = model.Description;
            product.Color = model.Color;
            product.Size = model.Size;
            product.Price = model.Price;
            


            return RedirectToAction("Products");
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            var product = DbContext._products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            
             
            DbContext._products.Remove(product);


            return RedirectToAction("Products");
        }

        public IActionResult Slidebar()
        {
            DbContext dbContext = new DbContext();
            return View(DbContext._slidebars);

        }

        public IActionResult SlidebarAdd()
        {

            return View();

        }

        [HttpPost]
        public IActionResult SubmitSlidebar(Slidebar slidebar)
        {

            DbContext._slidebars.Add(slidebar);

            return RedirectToAction("Slidebar");
        }

        public IActionResult SlidebarEdit(int id)
        {
            var slidebar = DbContext._slidebars.FirstOrDefault(p => p.Id == id);
            if (slidebar == null)
            {
                return NotFound();
            }
            return View(slidebar);

        }

        public IActionResult EditSubmitSlidebar(SlidebarUpdateViewModel model)
        {
            var slidebar = DbContext._slidebars.FirstOrDefault(p => p.Id == model.Id);
            if (slidebar == null)
            {
                return NotFound();
            }

            slidebar.Title = model.Title;
            slidebar.Description = model.Description;
            slidebar.Order = model.Order;


            return RedirectToAction("Slidebar");
        }

        [HttpGet]
        public IActionResult DeleteSlidebar(int id)
        {
            var slidebar = DbContext._slidebars.FirstOrDefault(p => p.Id == id);
            if (slidebar == null)
            {
                return NotFound();
            }


            DbContext._slidebars.Remove(slidebar);


            return RedirectToAction("Slidebar");
        }
    }
}
