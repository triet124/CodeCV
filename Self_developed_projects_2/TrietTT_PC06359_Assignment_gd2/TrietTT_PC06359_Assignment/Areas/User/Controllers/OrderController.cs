using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Data;
using TrietTT_PC06359_Assignment.Models;

namespace TrietTT_PC06359_Assignment.Areas.User.Controllers
{
    [Area("User")]
    public class OrderController : Controller
    {
        public readonly ApplicationDBContext _db;
        public OrderController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Order(int id)
        {
            //int customerId = HttpContext.Session.GetInt32("CustomerId") ?? default(int);

            List<Orders> orders = _db.Orders.Where(x => x.CustomerID == id).Include(b => b.Customers).Include(a=> a.Cars).Include(c => c.Cars.Categories).ToList();
            return View(orders);
        }
        public IActionResult OrderDetails (int id)
        {
            List<OrderDetails> orderDetails = _db.OrderDetails.Where(a => a.OrderID == id).Include(b => b.Orders).ToList();
            return View(orderDetails);
        }
    }
}
