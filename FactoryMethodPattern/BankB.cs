using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class BankB : IBank
    {
        public string Withdraw()
        {
            return "Your Request Is Handling By Bank B";
        }
    }
}
