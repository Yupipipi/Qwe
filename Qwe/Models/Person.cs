using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Person : IGetInfo //применение интерфейса
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Address { get; set; }
        public virtual string GetFullname()
        {
            return "ФИО: " + Surname + " " + Name + " " + Middlename;
        }
        public virtual int Age { get; set; } //при помощи virtual создается возможность для переопределения
    }
}