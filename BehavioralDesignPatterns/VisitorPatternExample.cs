using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    //Visitor Interface
    public interface IVisitor
    {
        void Visit(Element element);
    }

    //Concrete Visitor
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            employee.income *= 1.10;
            Console.WriteLine($"Updated income for {employee.GetType().Name} : {employee.name} = {employee.income}");
        }
    }

    //Concrete Visitor
    public class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;
            employee.vacationDays += 2;
            Console.WriteLine($"Updated Vacation days for {employee.GetType().Name} : {employee.name} = {employee.vacationDays}");
        }
    }

    //Context Element
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    //Employee Class
    public class Employee : Element
    {
        public string name;
        public double income;
        public int vacationDays;
        public Employee(string name, double income, int vacationDays)
        {
            this.name = name;
            this.income = income;
            this.vacationDays = vacationDays;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Employees
    {
        private List<Employee> employees = new List<Employee>();
        public void add(Employee emp)
        {
            employees.Add(emp);
        }
        public void remove(Employee emp)
        {
            employees.Remove(emp);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var each in employees)
                each.Accept(visitor);
        }
    }

    class ClerkLocal : Employee
    {
        public ClerkLocal() : base("King", 20000, 5)
        {

        }
    }

    class ManagerLocal : Employee
    {
        public ManagerLocal() : base("Kochhar", 22000, 15)
        {

        }
    }

    class VisitorPatternExample
    {
        //static void Main(string[] args)
        //{
        //    Employees emps = new Employees();

        //    emps.add(new ClerkLocal());
            
        //    emps.add(new ManagerLocal());

        //    emps.Accept(new IncomeVisitor());
        //    emps.Accept(new VacationVisitor());

        //    Console.Read();
        //}
    }
}
