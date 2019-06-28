namespace Shop.Services.Interfaces
{
    interface IGetInfo
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Middlename { get; set; }
        string Address { get; set; }
    }
}
