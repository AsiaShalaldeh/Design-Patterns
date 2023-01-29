namespace PrototypePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Prototype pattern provides a mechanism to copy the original object to
            // a new object and then modify it according to our needs.

            Employee tempEmployee = new TempEmployee();
            tempEmployee.ID = 1;
            tempEmployee.Name = "John Doe";
            tempEmployee.Address = new Address
            {
                Building = "B1",
                StreetName = "Street 1",
                City = "City 1",
            };
            /// Shallow : both objects point to the same address in memory 
            /// so any change made by an object, it will affect the other.
            /// Create ONLY ONE instance
            Employee tempEmployee2 = tempEmployee.ShallowCopy();

            /// Deep : each object points to a different address in memory
            /// so any change made by an object, it will not affect the other.
            /// Create TWO instances
            //Employee tempEmployee2 = tempEmployee.DeepCopy();

            Console.WriteLine("Temp Employee 1");
            Console.WriteLine(tempEmployee.ToString());
            Console.WriteLine("Temp Employee 2");
            Console.WriteLine(tempEmployee2.ToString());

            tempEmployee2.Address.StreetName = "New Street";

            Console.WriteLine("=============================");
            Console.WriteLine("Temp Employee 1");
            Console.WriteLine(tempEmployee.ToString());
            Console.WriteLine("Temp Employee 2");
            Console.WriteLine(tempEmployee2.ToString());
        }
    }
}

