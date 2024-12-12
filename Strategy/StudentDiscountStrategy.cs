namespace Strategy
{
    public class StudentDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            Console.WriteLine("Applying student discount.");
            return price * 0.85m;
        }
    }
}
