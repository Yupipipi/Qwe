namespace Qwe.Models
{
    public class Person : IGetInfo //применение интерфейса
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Address { get; set; }
        public virtual string GetFullname()
        {
            string s = Name;
            char c = 'а';
            int i = s.WordCount(c);  //применение расширения
            string Fullname = "ФИО: " + Surname + " " + Name + " " + Middlename + " Количество букв 'а' в имени = " + i;
            return(Fullname);
        }
        public virtual int Age { get; set; } //при помощи virtual создается возможность для переопределения
    }
}