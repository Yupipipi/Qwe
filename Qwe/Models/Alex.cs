using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Alex
    {
        static void Main()
        {
            Person alex = new Person();  //срабатывает конструктор по умолчанию
            alex.Name = "Alex";
            alex.Age = 20;
        }
    }
}