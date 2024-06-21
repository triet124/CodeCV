using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TrietTT_PC06359_Assignment.Models
{
    public class Cars
    {

        [Key]
        public int CarID { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int Gia { get; set; }
        public int NamSanXuat { get; set; }
        public string TinhTrang { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuongTon { get; set; }

        [ForeignKey("Categories")]
        public int CategoryID { get; set; }

        public Categories? Categories { get; set; }
        ICollection<Orders> Orders { get; set; }
    }
}

