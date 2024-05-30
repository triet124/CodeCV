using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrietTT_PC06359_Assignment.Data;
using TrietTT_PC06359_Assignment.Migrations;
using TrietTT_PC06359_Assignment.Models;

namespace TrietTT_PC06359_Assignment.Areas.User.Controllers
{
    [Area("User")]
    public class PayController : Controller
    {
        private readonly ApplicationDBContext _dbcontex;
        public PayController(ApplicationDBContext db)
        {
            _dbcontex = db;
        }
        public IActionResult Pay_view(int id)
        {
            var cars = _dbcontex.Cars.Where(x => x.CarID == id).Include(x => x.Categories).ToList();
            return View(cars);
        }





        //     [HttpPost]
        // public IActionResult Pay_view(Orders model, string paymentMethod, int id)
        // {
        //     // Lấy thông tin từ form và tạo hóa đơn mới
        //     var order = new Orders
        //     {
        //         CarID = model.CarID,
        //         CustomerID = model.CustomerID,
        //         NgayDat = DateTime.Now // Hoặc thời gian khác tùy thuộc vào yêu cầu của bạn
        //     };

        //     _dbcontex.Orders.Add(order);
        //     _dbcontex.SaveChanges();

        //     // Tạo các chi tiết hóa đơn tương ứng
        //     var orderDetail = new OrderDetails
        //     {
        //         OrderID = order.OrderID,
        //         NgayTao = DateTime.Now, // Hoặc thời gian khác
        //         TongGia = order.Cars.Gia,
        //SoLuong = 1,
        //         TinhTrangThanhToan = paymentMethod// Lấy thông tin từ form
        //     };

        //     _dbcontex.OrderDetails.Add(orderDetail);
        //     _dbcontex.SaveChanges();

        //var cars = _dbcontex.Cars.Where(x => x.CarID == id).Include(x => x.Categories).ToList();
        //         //return View(cars);
        //         return RedirectToAction("Index", "Home"); // Hoặc trả về view hoặc redirect đến trang khác
        //     }
        // }
    }
}
