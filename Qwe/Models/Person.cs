using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Person
    {
        public string Name;
        public string Surname;
        public string Fathersname;
        public virtual int Age { get; set; } //при помощи virtual создается возможность для переопределения
    }
}