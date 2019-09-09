using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    interface AnotherVehicleFactory
    {
        AbBike GetBike(string Bike);
        AbScooter GetScooter(string Scooter);
    }

    class HondaFactory : AnotherVehicleFactory
    {
        public AbBike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    return new SportsBike();
            }
        }
        public AbScooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default: return new Scooty();
            }
        }
    }

    class HeroHondaFactory : AnotherVehicleFactory
    {
        public AbBike GetBike(string Bike)
        {
            switch (Bike)
            {
                case "Sports":
                    return new SportsBike();
                case "Regular":
                    return new RegularBike();
                default:
                    return new SportsBike();
            }
        }
        public AbScooter GetScooter(string Scooter)
        {
            switch (Scooter)
            {
                case "Sports":
                    return new Scooty();
                case "Regular":
                    return new RegularScooter();
                default:
                    return new Scooty();
            }
        }
    }

    interface AbBike
    {
        string Name();
    }
    interface AbScooter
    {
        string Name();
    }

    class SportsBike : AbBike
    {
        public string Name()
        {
            return "Sports Bike";
        }
    }

    class RegularBike : AbBike
    {
        public string Name()
        {
            return "Regular Bike";
        }
    }

    class Scooty : AbScooter
    {
        public string Name()
        {
            return "Scooty";
        }
    }

    class RegularScooter : AbScooter
    {
        public string Name()
        {
            return "Regular Scooter";
        }
    }

    class VechicleClient
    {
        AbBike bike;
        AbScooter scooter;

        public VechicleClient(AnotherVehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            scooter = factory.GetScooter(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }
        public string GetScooterName()
        {
            return scooter.Name();
        }

    }

    class AbstractFactoryPatternExample
    {
        //static void Main(string[] args)
        //{
        //    VechicleClient hondaClient = new VechicleClient(new HondaFactory(), "Sports");
        //    Console.WriteLine(hondaClient.GetBikeName());
        //    Console.WriteLine(hondaClient.GetScooterName());
        //    Console.Read();
        //}
    }
}
