using System;

namespace BehavioralDesignPatterns
{
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }

    abstract class Approver
    {
        //Event
        public EventHandler<LoanEventArgs> Loan;

        //Event Handler
        public abstract void LoanHandler(object sender, LoanEventArgs args);
        public Approver()
        {
            Loan += LoanHandler;
        }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }

        //Invoke the loan event
        public virtual void OnLoan(LoanEventArgs args)
        {
            if(Loan != null)
            {
                Loan(this, args);
            }
        }

        //Property the next approver
        public Approver Successor { get; set; }
    }

    class Clerk : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs args)
        {
            if (args.Loan.Amount < 25000)
                Console.WriteLine($"{ this.GetType().Name } Approval Request #{args.Loan.Number}");
            else if (Successor != null)
                Successor.LoanHandler(this, args);            
        }
    }

    class AssistantManager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs args)
        {
            if (args.Loan.Amount < 45000)
                Console.WriteLine($"{ this.GetType().Name } Approval Request #{args.Loan.Number}");
            else if (Successor != null)
                Successor.LoanHandler(this, args);
        }
    }

    class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs args)
        {
            if (args.Loan.Amount < 100000)
                Console.WriteLine($"{ this.GetType().Name } Approval Request #{args.Loan.Number}");
            else if (Successor != null)
                Successor.LoanHandler(this, args);
            else
                Console.WriteLine($"{args.Loan.Number} executes a meeting");
        }
    }

    class Loan
    {
        public double Amount { get; set; }

        public string PurposeOfLoan { get; set; }

        public int Number { get; set; }
    }

    class ChainOfResponsibilityPatternExample
    {
        //static void Main(string[] args)
        //{
        //    //Setup chain of responsibilites

        //    Approver clerk = new Clerk();
        //    Approver asstManager = new AssistantManager();
        //    Approver manager = new Manager();

        //    clerk.Successor = asstManager;
        //    asstManager.Successor = manager;

        //    var loan = new Loan { Number = 2001, Amount = 24000, PurposeOfLoan = "Laptop Loan" };
        //    clerk.ProcessRequest(loan);

        //    loan = new Loan { Number = 2002, Amount = 40000, PurposeOfLoan = "Bike Loan" };
        //    clerk.ProcessRequest(loan);

        //    loan = new Loan { Number = 2003, Amount = 150000, PurposeOfLoan = "Home Loan" };
        //    clerk.ProcessRequest(loan);

        //    Console.Read();
        //}
    }
}
