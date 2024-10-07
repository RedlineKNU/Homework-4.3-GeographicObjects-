using GeographicObjects; 

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        River river = new River
        {
            X = 25.0m,
            Y = 45.0m,
            Name = "Дніпро",
            Description = "Велика річка в Україні.",
            FlowSpeed = 50.0m,
            TotalLength = 2201.0m
        };
        Mountain mountain = new Mountain
        {
            X = 30.0m,
            Y = 50.0m,
            Name = "Говерла",
            Description = "Найвища гора України.",
            HighestPoint = 2061.0m
        };
        Console.WriteLine(river.GetInfo());
        Console.WriteLine(mountain.GetInfo());
    }
}
