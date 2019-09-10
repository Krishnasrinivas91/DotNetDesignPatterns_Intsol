using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{
    public interface ITarget
    {
        List<string> GetEmployeesList();
    }

    public class BillingSystem
    {
        private ITarget employeeSource;
        public BillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            List<string> employees = employeeSource.GetEmployeesList();
            foreach(var each in employees)
            {
                Console.WriteLine(each);
            }
        }
    }

    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];
            employees[0] = new string[] { "1001", "Ing", "Team Leader" };
            employees[1] = new string[] { "1002", "Ueen", "Developer" };
            employees[2] = new string[] { "1003", "Ness", "Developer" };
            employees[3] = new string[] { "1004", "Zan", "Tester" };
            return employees;
        }        
    }

    public class EmployeeAdapter : HRSystem, ITarget
    {
        public List<string> GetEmployeesList()
        {
            List<string> returnObject = new List<string>();
            string[][] empList = GetEmployees();
            foreach(var each in empList)
            {
                returnObject.Add(each[1]);
            }
            return returnObject;
        }
    }

    class AdapterPatternExample
    {
        //static void Main(string[] args)
        //{
        //    ITarget target = new EmployeeAdapter();
        //    BillingSystem client = new BillingSystem(target);
        //    client.ShowEmployeeList();
        //    Console.Read();
        //}
    }
}
