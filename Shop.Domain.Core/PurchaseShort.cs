using System;

namespace Shop.Domain.Core
{
    public class PurchaseShort
    {
        public int PurchaseId { get; set; }
        public int ShortId { get; set; }
        public DateTime Date { get; set; }
    }
}
