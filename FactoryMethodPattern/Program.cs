using System;

namespace FactoryMethodPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            /// Client
            /// Any changes made will not be written here 
            /// Client doesn't know the details 
            /// I can add Bank C easily
            /// Object of bank will be created using an interface IBankFactory
            Console.Write("Enter Card Number : ");
            string cardNumber = Console.ReadLine();
            string bankCode = cardNumber.Substring(0, 6);
            BankFactory bankFactory = new BankFactory();
            IBank bank = bankFactory.GetBank(bankCode);
            Console.WriteLine(bank.Withdraw());

        }
    }
}
