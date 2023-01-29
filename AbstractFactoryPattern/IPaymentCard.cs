using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal interface IPaymentCard
    {
        string GetName();
        string GetProviderInfo();
    }
}
