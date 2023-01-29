using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class RegularEmployee : Employee
    {
        public override Employee ShallowCopy()
        {
            return (RegularEmployee) this.MemberwiseClone();
        }

        public override Employee DeepCopy()
        {
            RegularEmployee emp = new RegularEmployee();
            emp = (RegularEmployee)this.MemberwiseClone();
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
