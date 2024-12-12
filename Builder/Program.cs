using Builder;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director();
        HouseBuilder builder = new HouseBuilder();
        director.SetBuilder(builder);

        Console.WriteLine("Building a simple house:");
        director.BuildSimpleHouse();
        Console.WriteLine(builder.GetResult().Describe());

        Console.WriteLine("\nBuilding a full house:");
        director.BuildFullHouse();
        Console.WriteLine(builder.GetResult().Describe());

        Console.WriteLine("\nBuilding a custom house:");
        builder.BuildFloor();
        builder.BuildRoof();
        Console.WriteLine(builder.GetResult().Describe());
    }
}