using System.Data.Entity;

namespace Qwe.Models
{
    public class ShopShortContext : DbContext
    {
        public DbSet<Short> Shorts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}