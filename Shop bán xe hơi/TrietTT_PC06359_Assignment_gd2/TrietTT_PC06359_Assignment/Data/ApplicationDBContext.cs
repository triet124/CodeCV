using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace TrietTT_PC06359_Assignment.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<TrietTT_PC06359_Assignment.Models.Cars> Cars { get; set; }
        public DbSet<TrietTT_PC06359_Assignment.Models.Categories> Categories { get; set; }
        public DbSet<TrietTT_PC06359_Assignment.Models.Customers> Customers { get; set; }
        public DbSet<TrietTT_PC06359_Assignment.Models.Orders> Orders { get; set; }
        public DbSet<TrietTT_PC06359_Assignment.Models.OrderDetails> OrderDetails { get; set; }

    }

}