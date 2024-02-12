using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShop.Models;

namespace MyShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BicycleController : Controller
    {
        private readonly ShopContext _context;

        public BicycleController(ShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("[area]/bicycles/{brand?}")]
        public IActionResult List(string brand = "all")
        {
            List<Bicycle> bicycles;

            if (brand.Equals("all"))
            {
                bicycles = _context.Bicycles.ToList();
            }
            else
            {
                bicycles = _context.Bicycles.Where(b => b.Brand == brand).ToList();
            }

            return View(bicycles);
        }

        [HttpGet]
        public IActionResult Add(int? id)
        {
            if (id.HasValue)
            {
                var bicycle = _context.Bicycles.Find(id.Value);
                if (bicycle != null)
                {
                    return View("AddEdit", bicycle);
                }
            }
            return View("AddEdit", new Bicycle());
        }

        [HttpPost]
        public IActionResult Add(Bicycle bicycle)
        {
            //Add operation if id is 0
            
            if (ModelState.IsValid)
            {
                if(bicycle.Id == 0)
                {
                    _context.Bicycles.Add(bicycle);
                }
                else
                {
                    _context.Bicycles.Update(bicycle);
                }
              
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            return View("AddEdit", bicycle);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var bicycle = _context.Bicycles.Find(id);
            if (bicycle != null)
            {
                return View(bicycle);
            }
            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult DeleteBike(int id)
        {
            var bicycle = _context.Bicycles.Find(id);
            if (bicycle != null)
            {
                _context.Bicycles.Remove(bicycle);
                _context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
