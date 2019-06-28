using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Shop.Domain.Core;
using Shop.Domain.Interfaces;

namespace Shop.Infrastructure.Data
{
    public class PensRepository : IPensRepository
    {
        private PensContext db;

        public PensRepository()
        {
            this.db = new PensContext();
        }

        public void Buy(PurchasePens purchase)
        {
            purchase.Date = DateTime.Now;
            db.PurchasesPenses.Add(purchase);
        }

        public Pens GetPens(int id)
        {
            return db.Penses.Find(id);
        }

        public void Create(Pens info)
        {
            db.Penses.Add(info);
        }

        public void Update(Pens info)
        {
            db.Entry(info).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Pens info = db.Penses.Find(id);
            if (info != null)
                db.Penses.Remove(info);
        }

        public void Save()
        {
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
