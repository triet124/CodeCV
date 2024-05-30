using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrietTT_PC06359_Assignment.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }

        [ForeignKey("Orders")]
        public int OrderID { get; set; }

        public DateTime NgayTao { get; set; }
        public int TongGia { get; set; }
        public int SoLuong { get; set; }
        public string TinhTrangThanhToan { get; set; }

        public Orders? Orders { get; set; }
    }
}
