namespace Decorator
{
    public class LoggingPaymentServiceDecorator : IPaymentService
    {
        private readonly IPaymentService _paymentService;

        public LoggingPaymentServiceDecorator(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessPayment()
        {
            Console.WriteLine("Logging: Payment processing started.");
            _paymentService.ProcessPayment();
            Console.WriteLine("Logging: Payment processing finished.");
        }
    }

}
