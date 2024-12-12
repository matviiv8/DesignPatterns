namespace Strategy
{
    public class HolidayDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            Console.WriteLine("Applying holiday discount.");
            return price * 0.80m;
        }
    }
}
