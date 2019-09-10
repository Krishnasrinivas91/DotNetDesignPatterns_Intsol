using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{

    public interface IClient
    {
        string GetData();
    }

    class RealClient : IClient
    {
        string Data;
        public RealClient()
        {
            Console.WriteLine("Real Client : Initialized..");
            Data = "Hello World from Real Client";
        }
        public string GetData()
        {
            return this.Data;
        }
    }

    class ProxyClient : IClient
    {
        RealClient client;
        public ProxyClient()
        {
            client = new RealClient();
            Console.WriteLine("Proxy Client: Initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }

    class ProxyPatternExample
    {
        static void Main(string[] args)
        {
            ProxyClient pc = new ProxyClient();
            Console.WriteLine($"Data from Proxy Client : {pc.GetData()}");

            Console.Read();
        }
    }
}
