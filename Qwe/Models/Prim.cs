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
    class Person
    {
        public string name;
        public virtual int age { get; set; } //при помощи virtual создается возможность для переопределения
    }
    class Dop : Person //наследуется класс Person; доступ не может быть выше, чем у родителя; по умолчанию имеет доступ internal
    {
        protected int Number { get; set; }

        private int Age;
        public override int age //просиходит переопределение
        {
            get
            {
                return Age;
            }
            set
            {
                if (value > 17)
                {
                    Age = value;
                }
            }
        }
    }
    class Dopoln : Dop
    {
        protected internal bool Hello { get; set; }
        protected private int Sum { get; set; }
    }
    class Alex
    {
        static void Main()
        {
            Person alex = new Person();  //срабатывает конструктор по умолчанию
            alex.name = "Alex";
            alex.age = 20;
        }
    }
    class Persons
    {
        public string name;
        public int age;

        public Persons(string a) { name = a; age = 0; }
        public Persons(string a, int b) {name = a; age = b;}
    }
    class Prov
    {
        static void Main()
        {
            Persons ivan = new Persons("Ivan");  //конструкторы с параметрами
            Persons max = new Persons("Max", 20);
        }
    }
    class Robot
    {
        static Robot() { }
    }
    class Robots
    {
        static void Main()
        {
            Robot robot1 = new Robot();  //статич конструктор срабатывет при первом создании объекта
            Robot robot2 = new Robot();
            int a = 10;
        }
    }
}