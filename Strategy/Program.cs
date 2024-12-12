using Strategy;

class Program
{
    static void Main(string[] args)
    {
        var priceCalculator = new PriceCalculator();

        Console.WriteLine("Base price: $100.00\n");

        Console.WriteLine("Case 1: Applying student discount:");
        priceCalculator.SetDiscountStrategy(new StudentDiscountStrategy());
        Console.WriteLine($"Final price: ${priceCalculator.CalculatePrice(100.00m):F2}\n");

        Console.WriteLine("Case 2: Applying holiday discount:");
        priceCalculator.SetDiscountStrategy(new HolidayDiscountStrategy());
        Console.WriteLine($"Final price: ${priceCalculator.CalculatePrice(100.00m):F2}\n");

        Console.WriteLine("Case 3: No discount applied:");
        priceCalculator.SetDiscountStrategy(new NoDiscountStrategy());
        Console.WriteLine($"Final price: ${priceCalculator.CalculatePrice(100.00m):F2}\n");
    }
}