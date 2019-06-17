﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public class Dop : Person //наследуется класс Person; доступ не может быть выше, чем у родителя; по умолчанию имеет доступ internal
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
}