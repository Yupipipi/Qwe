using System;namespace Qwe.Models
{
    public class Purchasep : Person
    {
        // ID покупки
        public int PurchasepId { get; set; }
        // ID 
        public int PensId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
        public override string GetFullname() //переопределение
        {
            return "ФИО: " + Surname + " " + Name + " " + Middlename + " Адрес: " + Address;
        }
    }
}