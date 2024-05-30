using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrietTT_PC06359_Assignment.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("Customers")]
        public int CustomerID { get; set; }

        [ForeignKey("Cars")]
        public int CarID { get; set; }

        public DateTime NgayDat { get; set; }
        public Customers? Customers { get; set; }
        public Cars? Cars { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
