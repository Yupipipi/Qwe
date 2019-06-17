using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Person
    {
        public string name;
        public virtual int age { get; set; } //при помощи virtual создается возможность для переопределения
    }
}