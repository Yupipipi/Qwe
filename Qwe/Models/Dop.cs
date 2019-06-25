namespace Qwe.Models
{
    public class Dop : Person //наследуется класс Person; доступ не может быть выше, чем у родителя; по умолчанию имеет доступ internal
    {
        protected int Number { get; set; }

        private int age;
        public override int Age //просиходит переопределение
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 17)
                {
                    age = value;
                }
            }
        }
    }
}