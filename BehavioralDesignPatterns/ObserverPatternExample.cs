using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    //Subject Interface
    interface IProduct
    {
        //Attach the Observer
        void Subscribe(Customer customer);

        // Detach the Observer
        void Unsubscribe(Customer customer);

        //Publish Notification to the Subscribers
        void Notify();
    }

    //Concrete Subject Class
    public class Product : IProduct
    {
        string productName;
        float basePrice;
        float currentPrice;

        List<Customer> customers = new List<Customer>();

        public Product(string productName, float basePrice)
        {
            this.productName = productName;
            this.basePrice = basePrice;
            this.currentPrice = basePrice;
        }

        public float price
        {
            get { return currentPrice; }
            set
            {
                currentPrice = value;
                if (value != basePrice)
                {
                    Notify();
                }
            }
        }

        public string ProductName
        {
            get { return productName; }
        }

        public float CurrentPrice
        {
            get { return currentPrice; }
        }

        public float discount
        {
            get { return (basePrice - currentPrice) * 100 / basePrice; }
        }

        public void Notify()
        {
            foreach (Customer observer in customers)
            {
                observer.Update(this);
            }
        }

        public void Subscribe(Customer customer)
        {
            customers.Add(customer);
        }

        public void Unsubscribe(Customer customer)
        {
            customers.Remove(customer);
        }
    }

    //Observer Interface
    interface ICustomer
    {
        void Update(Product product);
    }

    //Concrete Observer Class
    public class Customer : ICustomer
    {
        string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public void Update(Product product)
        {
            Console.WriteLine($"{this.name} : {product.ProductName} Laptop is now available at {product.CurrentPrice}; Discount = {product.discount}%");
        }
    }

    //Client
    class ObserverPatternExample
    {
        //static void Main(string[] args)
        //{
        //    Product Laptop = new Product("Dell", 1000);
        //    Console.WriteLine("Two Customers Subscribed to the Laptop Product");

        //    Customer cust1 = new Customer("King");
        //    Laptop.Subscribe(cust1);

        //    Customer cust2 = new Customer("Kochhar");
        //    Laptop.Subscribe(cust2);

        //    Console.WriteLine("\nPublish Notification first time");

        //    //Publish Notification to the Subscribers
        //    Laptop.price = 800;

        //    Laptop.Unsubscribe(cust2);

        //    Customer cust3 = new Customer("Steve");
        //    Laptop.Subscribe(cust3);

        //    Console.WriteLine("\nPublish Notification second time");

        //    //Publish Notification to the Subscribers
        //    Laptop.price = 900;

        //    Console.Read();
        //}
    }
}
