using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public abstract Employee ShallowCopy();
        public abstract Employee DeepCopy();

        public override string ToString()
        {
            return $"ID : {this.ID}\n" +
                $"Name : {this.Name}\n" +
                $"Address : {this.Address.Building},{this.Address.StreetName},{this.Address.City}";
        }

    }
}
