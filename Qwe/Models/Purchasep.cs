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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathersname { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        // ID 
        public int PensId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }

        public string GetFullname()
        {
            return "ФИО: " + Name + " " + Surname + " " + Fathersname;
        }
    }
}