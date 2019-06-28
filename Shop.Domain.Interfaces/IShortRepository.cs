using System;
using Shop.Domain.Core;

namespace Shop.Domain.Interfaces
{
    public interface IShortRepository : IDisposable
    {
        Short GetShort(int id);
        void Buy(PurchaseShort item);
        void Create(Short item);
        void Update(Short item);
        void Delete(int id);
    }
}
