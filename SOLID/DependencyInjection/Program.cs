using System;

namespace DependencyInjection
{
    /// <summary>
    ///  Example One:
    ///  a dependency is an object that a helps another class e.g newed up in a class - this is also tightly coupled
    ///  if we want to change the object we need to chnage a whole lot of code.
    ///  also if we want to unit test using this syntax it would be hard to do
    ///  
    ///  So instead of letting the class create another class we assign that responsibility somewhere else - this is called Inversion o9f COntrol
    ///  we are making it someone elses responsibility to create the object and pass it in
    ///  
    ///  Example 2 
    ///  Uses IOC and Dependency Inversion - this howver is called poor man dependency injection as you cans still only use CreditCardPaymentGatway (see constuctor)
    ///  This is called constructor injection, can also have proerty injection or method injection (for method injection see Dpenedency Inversion Principle Fixed
    ///  
    ///  Example 3
    ///  Totally decoupled and can use any paymentgateway as long as it implements the payment interface
    /// 
    /// </summary>

    // Example one
    public class CreditCardPaymentGateway1
    {
        public bool ProcessPayment() {

            return true;
        }
    }

    public class OrderProcessor1
    {
        public readonly CreditCardPaymentGateway1 _paymentGateway;

        public OrderProcessor1()
        {
            _paymentGateway = new CreditCardPaymentGateway1(); 
        }

        public bool ProcessOrder1()
        {
            //Do some other things here, then process payment

            bool success = _paymentGateway.ProcessPayment();

            return success;
        }
    }

    //Example Two
    public class CreditCardPaymentGateway2
    {
        public bool ProcessPayment()
        {

            return true;
        }
    }

    public class OrderProcessor2
    {
        public readonly CreditCardPaymentGateway2 _paymentGateway;

        public OrderProcessor2(CreditCardPaymentGateway2 paymentGateway) 
        {
            _paymentGateway = paymentGateway;
        }

        public bool ProcessOrder2()
        {
            //Do some other things here, then process payment

            bool success = _paymentGateway.ProcessPayment();

            return success;
        }
    }

    //Example Three
    public interface IPaymentGateway
    {
        bool ProcessPayment();
    }


    public class CreditCardPaymentGateway3 : IPaymentGateway
    {
        public bool ProcessPayment()
        {
            return true;
        }
    }

    public class OrderProcessor3
    {
        public readonly IPaymentGateway _paymentGateway;

        public OrderProcessor3(IPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }

        public bool ProcessOrder3()
        {
            //Do some other things here, then process payment

            bool success = _paymentGateway.ProcessPayment();

            return success;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
