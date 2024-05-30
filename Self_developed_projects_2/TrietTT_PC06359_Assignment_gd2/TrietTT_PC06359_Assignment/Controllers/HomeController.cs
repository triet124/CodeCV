using TrietTT_PC06359_Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TrietTT_PC06359_Assignment.Models;

namespace TrietTT_PC06359_Assignment.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _dbcontex;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext db)
		{
			_logger = logger;
			_dbcontex = db;
		}
        public IActionResult Index()
		{
            List<Cars> Cars = _dbcontex.Cars.Include(c => c.Categories).ToList();
            return View(Cars);
        }

		public IActionResult Login(Customers customers)
		{
			var userID = customers.CustomerID;
			var userPW = customers.MatKhau;
			var userName = customers.HoTen;
            var userTK = customers.Email;
			var query = _dbcontex.Customers.SingleOrDefault(x => x.Email.Equals(userTK) && x.MatKhau.Equals(userPW) );
			if(query != null) 
			{
                if (query.PhanQuyen.Equals("admin"))
				{
					return RedirectToAction("Index","Cars", new {area = "Admin"});
				}
				else if(query.PhanQuyen.Equals("user"))
				{
					HttpContext.Session.SetInt32("CustomerId", query.CustomerID);
					HttpContext.Session.SetString("Name", query.HoTen);
					return RedirectToAction("Index", "User", new { area = "User" });
				}
				else
				{
                    ViewBag.ErrorMessage = "Sai tên đăng nhập hoặc mật khẩu";
                    return View();
                    //ViewBag.ErrorMessage = "Đăng nhập thất bại, tài khoản hoặc mật khẩu không đúng";
                    //return View("Login");
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
