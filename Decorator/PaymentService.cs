namespace Decorator
{
    public class PaymentService : IPaymentService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing payment...");
        }
    }
}
