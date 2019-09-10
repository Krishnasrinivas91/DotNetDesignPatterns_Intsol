using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{

    public class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine("CarModel - Selected");
        }
    }

    public class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine("CarEngine - Selected");
        }
    }

    public class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine("CarBody - Selected");
        }
    }


    public class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine("CarAccessories - Selected");
        }
    }

    public class Facade
    {
        private CarModel carModel;
        private CarEngine carEngine;
        private CarBody carBody;
        private CarAccessories carAccessories;

        public Facade()
        {
            carModel = new CarModel();
            carEngine = new CarEngine();
            carBody = new CarBody();
            carAccessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******* Creating Car ********");
            carModel.SetModel();
            carEngine.SetEngine();
            carBody.SetBody();
            carAccessories.SetAccessories();
        }
    }

    class FacadePatternExample
    {
        //static void Main(string[] args)
        //{
        //    Facade fc = new Facade();
        //    fc.CreateCompleteCar();

        //    Console.Read();
        //}
    }
}
