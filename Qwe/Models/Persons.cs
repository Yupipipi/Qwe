namespace Qwe.Models
{
    public class Persons : Person
    {
        public Persons(string a, string b, string c, string d) { Name = a; Surname = b; Middlename = c; Address = d; }
        public Persons(string a, int b) { Name = a; Age = b; }
    }
}