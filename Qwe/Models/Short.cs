using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{ 
    public class Short : Clothe //применение абстрактного класса
    {
        public int Id { get; set; }
        public string Name { get; set; } = "noname";
        public string Size { get; set; } = "S";
        public int Price { get; set; } = 50;
    }
}