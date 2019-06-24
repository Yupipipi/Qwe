using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Qwe.Models
{
    public static class StringExtension  //метод расширения
    {
        public static int WordCount(this string str, char c)
        {
            int counter = 0;
            string answer = "Да";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
}