using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    sealed class Net //класс не наследуется
    {
        int a; // по умолчанию доступ private
        private int b; // в классе
        protected int c; // в классе и производных
        public int f; // любое место
        internal int d; // любое место в данной сборке
        protected internal int e; // любое место и наследники
        protected private int g; // в классе и производных в проекте
    } 
    //class Op : Net { } будет ошибка
    public class Prim
    { 
        string Name { get; set; } 
        public int Age { get; set; }
        private string Sex { get; set; }
    }
     class Dop : Prim //наследуется класс Prim; доступ не может быть выше, чем у родителя; по умолчанию имеет доступ internal
    {
        protected int Number { get; set; }
    }
    class Dopoln : Dop
    {
        protected internal bool Hello { get; set; }
        protected private int Sum { get; set; }
    }
}