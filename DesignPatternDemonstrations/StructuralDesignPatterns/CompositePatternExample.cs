using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{

    public interface IEmployee
    {
        int EmpId { get; set; }
        string EmpName { get; set; }
    }

    public class Employee : IEmployee, IEnumerable<Employee>
    {
        List<IEmployee> nodes = new List<IEmployee>();

        public int EmpId { get; set; }
        public string EmpName { get; set; }

        public void addNode(IEmployee node)
        {
            nodes.Add(node);
        }

        public void removeNode(IEmployee node)
        {
            nodes.Remove(node);
        }

        public IEmployee getNode(int index)
        {
            return nodes[index];
        }

        public IEnumerator<IEmployee> GetEnumerator()
        {
            foreach(IEmployee node in nodes)
            {
                yield return node;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator<Employee> IEnumerable<Employee>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class ContractualEmployee : IEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }

    class CompositePatternExample
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { EmpId = 1, EmpName = "King" };
            Employee emp2 = new Employee { EmpId = 2, EmpName = "Ueen" };
            Employee emp3 = new Employee { EmpId = 3, EmpName = "Jazz" };

            emp1.addNode(emp2);
            emp1.addNode(emp3);

            Employee emp4 = new Employee { EmpId = 4, EmpName = "Mark" };
            Employee emp5 = new Employee { EmpId = 5, EmpName = "Steve" };
            emp2.addNode(emp4);
            emp2.addNode(emp5);

            Employee emp6 = new Employee { EmpId = 6, EmpName = "Sam" };
            Employee emp7 = new Employee { EmpId = 7, EmpName = "Rosie" };
            ContractualEmployee emp8 = new ContractualEmployee { EmpId = 8, EmpName = "Steven" };
            ContractualEmployee emp9 = new ContractualEmployee { EmpId = 9, EmpName = "Joe" };
            emp3.addNode(emp6);
            emp3.addNode(emp7);
            emp3.addNode(emp8);
            emp3.addNode(emp9);

            Console.WriteLine($"Emp ID: {emp1.EmpId}, Emp Name: {emp1.EmpName}");
            foreach(Employee emp in emp1)
            {
                Console.WriteLine($"\t Emp ID: {emp.EmpId}, Emp Name: {emp.EmpName}");
                //if(emp.GetEnumerator() != null)
                //{
                    foreach(var each in emp)
                    {
                        Console.WriteLine($"\t \t Emp ID: {each.EmpId}, Emp Name: {each.EmpName}");
                    }
                //}
            }

            Console.Read();
        }
    }
}
