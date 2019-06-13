using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Purchasep
    {
        // ID покупки
        public int PurchasepId { get; set; }
        // имя и фамилия покупателя
        public string Person { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        // ID 
        public int PensId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}