using System.ComponentModel.DataAnnotations;

namespace TrietTT_PC06359_Assignment.Models
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int SoDienThoai { get; set; }
        public string MatKhau { get; set; }
        public string PhanQuyen { get; set; }
        public ICollection<Orders>? Orders { get; set; }

    }
}
