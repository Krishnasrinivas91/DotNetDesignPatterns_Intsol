using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    // IPrototype Interface
    public interface IEmployee
    {
        IEmployee Clone();
    }

    //Concrete Prototype class to implement IPrototype Interface
    class PermanentEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeType { get; set; }

        public IEmployee Clone()
        {
            //Shallow Copy
            return this.MemberwiseClone() as IEmployee;

            //Deep Copy
            //Implementing Memberwise clone method for every reference type object
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{Name} : {Age} : {EmployeeType}");
        }
    }

    class TemporaryEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeType { get; set; }

        public IEmployee Clone()
        {
            //Shallow Copy
            return this.MemberwiseClone() as IEmployee;

            //Deep Copy
            //Implementing Memberwise clone method for every reference type object
        }
    }

    class PrototypePatternExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Original Object *************");
            PermanentEmployee permanentEmployee = new PermanentEmployee();
            permanentEmployee.Name = "King Kochhar";
            permanentEmployee.Age = 24;
            permanentEmployee.EmployeeType = "Permanent";
            permanentEmployee.DisplayDetails();

            Console.WriteLine();
            Console.WriteLine("******** Cloned Object ***************");
            PermanentEmployee permanentEmployeeClone = (PermanentEmployee)permanentEmployee.Clone();
            permanentEmployeeClone.Name = "Queen Kochhar";
            permanentEmployeeClone.Age = 25;
            permanentEmployeeClone.DisplayDetails();
            Console.Read();
        }
    }
}
