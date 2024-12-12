namespace Strategy
{
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            Console.WriteLine("No discount applied.");
            return price;
        }
    }
}
