using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Persons
    {
        public string name;
        public int age;

        public Persons(string a) { name = a; age = 0; }
        public Persons(string a, int b) { name = a; age = b; }
    }
}