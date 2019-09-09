using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{

    class Singleton
    {
        private static Singleton instance = null;

        private string Name { get; set; }
        private string IP { get; set; }

        private Singleton()
        {
            Console.WriteLine("Singleton Instance");
            Name = "Default Server";
            IP = "192.168.1.1";
        }

        private static object syncLock = new object();

        public static Singleton Instance
        {
            get {
                lock (syncLock)
                {
                    if (Singleton.instance == null)
                        Singleton.instance = new Singleton();

                    return Singleton.instance;
                }
            } 
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Server Information:");
            Console.WriteLine($"Server Name : {Name}");
            Console.WriteLine($"IP Address : {IP}");
        }
    }

    class SingletonPatternExample
    {
        //static void Main(string[] args)
        //{
        //    Singleton sg = Singleton.Instance;
        //    sg.DisplayDetails();
        //    Console.Read();
        //}
    }
}
