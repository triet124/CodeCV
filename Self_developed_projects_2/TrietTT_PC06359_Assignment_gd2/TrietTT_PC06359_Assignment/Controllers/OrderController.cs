using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Data;
using TrietTT_PC06359_Assignment.Models;

namespace TrietTT_PC06359_Assignment.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDBContext _db;
        public OrderController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Order()
        {
            List<Orders> orders = new List<Orders>();
            return View(orders);
        }
        public IActionResult OrderDetails (int id)
        {
            List<OrderDetails> orderDetails = _db.OrderDetails.Where(a => a.OrderID == id).Include(b => b.Orders).ToList();
            return View(orderDetails);
        }
    }
}
