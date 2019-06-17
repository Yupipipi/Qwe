using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    sealed class Net //класс не наследуется
    {
        int a = 7; // по умолчанию доступ private
        private int b = 9; // в классе
        protected int c = 6; // в классе и производных
        public int f = 1; // любое место
        internal int d = 5; // любое место в данной сборке
        protected internal int e = 8; // любое место и наследники
        protected private int g = 2; // в классе и производных в проекте
    }
    //class Op : Net { } будет ошибка
}