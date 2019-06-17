using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // имя и фамилия покупателя
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathersname { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        // ID 
        public int ShortId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
        public string GetFullname()
        {
            return "ФИО: " + Name + " " + Surname + " " + Fathersname;
        }
    }
}