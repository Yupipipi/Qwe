using System;
namespace Qwe.Models
{
    public class Purchase : Person
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // ID 
        public int ShortId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }

        public Persons person = new Persons("Алексей", "Амельченко", "Александрович", "Минск");//new
    }
}