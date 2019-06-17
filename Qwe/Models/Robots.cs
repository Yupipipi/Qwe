using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Robots
    {
        static void Main()
        {
            Robot robot1 = new Robot();  //статич конструктор срабатывет при первом создании объекта
            Robot robot2 = new Robot();
        }
    }
}