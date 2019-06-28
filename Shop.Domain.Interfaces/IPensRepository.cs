using System;
using Shop.Domain.Core;

namespace Shop.Domain.Interfaces
{
    public interface IPensRepository : IDisposable
    {
        Pens GetPens(int id);
        void Buy(PurchasePens item);
        void Create(Pens item);
        void Update(Pens item);
        void Delete(int id);
        void Save();
    }
}
