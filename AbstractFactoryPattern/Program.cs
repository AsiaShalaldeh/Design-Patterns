using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            /// Factory of Factories
            /// Client is not responsible for writing the logic (if else)
            Console.Write("Enter Card Number : ");
            string cardNumber = Console.ReadLine();
            string bankCode = cardNumber.Substring(0, 6);
            BankFactory bankFactory = new BankFactory();
            IBank bank = bankFactory.GetBank(bankCode);

            Console.WriteLine(bank.Withdraw());

            IPaymentCard paymentCard = bankFactory.GetPaymentCard("12");
            Console.WriteLine(paymentCard.GetName());
        }
    }
}

