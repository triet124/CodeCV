using TrietTT_PC06359_Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Models;
using TrietTT_PC06359_Assignment.Data;

namespace TrietTT_PC06359_Assignment.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext _dbcontex;
        public ProductController(ApplicationDBContext db)
        {

            _dbcontex = db;
        }
        public IActionResult Prod()
        {
            List<Cars> cars = _dbcontex.Cars.Include(c => c.Categories).ToList();
            return View(cars);
        }
        public IActionResult Prod_details (int id)
        {
            List<Cars> cars = _dbcontex.Cars.Include(c => c.Categories).ToList();

            cars = _dbcontex.Cars.Where(x => x.CarID == id).ToList();
            return View(cars);
        }
    }
}
