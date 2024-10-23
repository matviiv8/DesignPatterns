using Decorator;

class Program
{
    static void Main(string[] args)
    {
        IPaymentService paymentService = new PaymentService();
        IPaymentService loggingDecorator = new LoggingPaymentServiceDecorator(paymentService);

        loggingDecorator.ProcessPayment();
    }
}
