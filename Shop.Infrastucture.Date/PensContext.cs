using Shop.Domain.Core;
using System.Data.Entity;

namespace Shop.Infrastructure.Data
{
    public class PensContext : DbContext
    {
        public DbSet<Pens> Penses { get; set; }
        public DbSet<PurchasePens> PurchasesPenses { get; set; }
    }
}
