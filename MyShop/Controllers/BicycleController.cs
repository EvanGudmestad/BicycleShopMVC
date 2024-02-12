using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers
{
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

        [Route("bicycles/{brand?}")]
        public IActionResult List(string brand = "all")
        {
            List<Bicycle> bicycles;

            if(brand.Equals("all"))
            {
                bicycles = _context.Bicycles.ToList();
            }
            else
            {
                bicycles = _context.Bicycles.Where(b => b.Brand == brand).ToList();
            }

            return View(bicycles);
        }

        [Route("bicycle/{id}/{slug?}")]
        public IActionResult Details(int id)
        {
            var bicycle = _context.Bicycles.Find(id);
            if (bicycle !=null && bicycle.ImageFileName != null)
            {
                bicycle.ImageFileName = "/images/" + bicycle.ImageFileName;
            }
            return View(bicycle);
        }
    }
}
