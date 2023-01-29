using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class TempEmployee:Employee
    {
        public override Employee ShallowCopy()
        {
            return (TempEmployee)this.MemberwiseClone();
        }

        public override Employee DeepCopy()
        {
            TempEmployee emp = new TempEmployee();
            emp = (TempEmployee)this.MemberwiseClone();
            emp.Address = new Address
            {
                Building = Address.Building,
                City = Address.City,
                StreetName = Address.StreetName,
            };
            emp.Name = this.Name;
            return emp;
        }
    }
}
