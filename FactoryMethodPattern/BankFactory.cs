using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class BankFactory : IBankFactory
    {
        /// <summary>
        ///  Instead of writing the logic in client we will write it here
        /// </summary>
        /// <param name="bankCode"></param>
        /// <returns></returns>
        public IBank GetBank(string bankCode)
        {
            if (bankCode == "111111")
            {
                return new BankA();
            }
            else if (bankCode == "123456")
            {
                return new BankB();
            }
            else
            {
                return null;
            }
        }
    }
}
