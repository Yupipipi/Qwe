using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Shop.Domain.Core;
using Shop.Domain.Interfaces;

namespace Shop.Infrastructure.Data
{
    public class ShortRepository : IShortRepository
    {
        private ShopContext db;

        public ShortRepository()
        {
            this.db = new ShopContext();
        }

        public void Buy(PurchaseShort purchase)
        {
            purchase.Date = DateTime.Now;
            db.PurchasesShorts.Add(purchase);
            db.SaveChanges();
        }

        public Short GetShort(int id)
        {
            return db.Shorts.Find(id);
        }

        public void Create(Short info)
        {
            db.Shorts.Add(info);
            db.SaveChanges();
        }

        public void Update(Short info)
        {
            db.Entry(info).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Short info = db.Shorts.Find(id);
            if (info != null)
                db.Shorts.Remove(info);
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
