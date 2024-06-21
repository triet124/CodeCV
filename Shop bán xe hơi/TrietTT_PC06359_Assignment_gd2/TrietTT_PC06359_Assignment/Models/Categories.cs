namespace TrietTT_PC06359_Assignment.Models
{
    public class Categories
    {
        public ICollection<Cars>? cars { get; set; }
        [System.ComponentModel.DataAnnotations.Key]
        public int CategoryID { get; set; }
        public string TenLoai { get; set; }
    }
}
