using Shop.Domain.Core;
using System.Data.Entity;

namespace Short.Infrastructure.Data
{
    public class ShopContext : DbContext
    {
        public DbSet<Short> Shorts { get; set; }
        public DbSet<PurchaseShort> PurchasesShorts { get; set; }
    }
}
