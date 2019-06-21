using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    interface IGetInfo //интерфейс
    {
        string Name{ get; set; }
        string Surname { get; set; }
        string Middlename { get; set; }
        string Address { get; set; }
    }
        
}