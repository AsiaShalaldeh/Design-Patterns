﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class BankA : IBank
    {
        public string Withdraw()
        {
            return "Your Request Is Handling By Bank A";
        }
    }
}
