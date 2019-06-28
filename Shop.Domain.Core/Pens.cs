namespace Shop.Domain.Core
{
    public class Pens
    {
        public int Id { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; } = "noname";
        public string Size { get; set; } = "S";
        public int Price { get; set; } = 50;
    }
}
