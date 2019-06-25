using System.Data.Entity;
namespace Qwe.Models
{
   public class ShopPensContext : DbContext
    {
        public DbSet<Pens> Penses { get; set; }
        public DbSet<Purchasep> Purchasesp { get; set; }
    }
}