using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    interface IFactory
    {
        void Drive(int miles);
    }

    class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Scooter : {miles.ToString()} KM");
        }
    }

    class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine($"Drive the Bike : {miles.ToString()} KM");
        }
    }

    abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }

    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch(Vehicle) 
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new Bike();
                default:
                    throw new ApplicationException($"Vehicle : {Vehicle} cannot be created");
            }
        }
    }

    class FactoryPatternExample
    {
        //static void Main(string[] args)
        //{
        //    VehicleFactory factory = new ConcreteVehicleFactory();
        //    Console.WriteLine("Enter Vehicle type (Scooter/Bike)");
        //    string vType = Console.ReadLine();
        //    IFactory obj = factory.GetVehicle(vType);
        //    obj.Drive(25);
        //    Console.Read();
        //}
    }
}
