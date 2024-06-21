using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Controllers;
using TrietTT_PC06359_Assignment.Data;
using TrietTT_PC06359_Assignment.Migrations;
using TrietTT_PC06359_Assignment.Models;

namespace TrietTT_PC06359_Assignment.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        private readonly ApplicationDBContext _dbcontex;
        public UserController(ApplicationDBContext db)
        {
            _dbcontex = db;
        }
        public IActionResult Index()
        {
            var cars = _dbcontex.Cars.Include(c => c.Categories).ToList();
            return View(cars);
        }
        public IActionResult Login(Customers customers)
        {
            int userID = customers.CustomerID;
            var userPW = customers.MatKhau;
            var userName = customers.HoTen;
            var userTK = customers.Email;
            var query = _dbcontex.Customers.SingleOrDefault(x => x.Email.Equals(userTK) && x.MatKhau.Equals(userPW));
            if (query != null)
            {
                if (query.PhanQuyen.Equals("admin"))
                {
                    return RedirectToAction("Index", "Cars", new { area = "Admin" });
                }
                else if (query.PhanQuyen.Equals("user"))
                {
                    return RedirectToAction("Index", "User", new { area = "User" });
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
