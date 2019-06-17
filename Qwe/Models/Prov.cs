using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Prov
    {
        static void Main()
        {
            Persons ivan = new Persons("Ivan");  //конструкторы с параметрами
            Persons max = new Persons("Max", 20);
        }
    }
}