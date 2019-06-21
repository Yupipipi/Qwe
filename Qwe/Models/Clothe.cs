using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Clothe // является абстрактным классом
    {
        public string Sex { get; set; }  
        private string Color { get; set; } //нельзя вызвать где-либо еще
    }
}