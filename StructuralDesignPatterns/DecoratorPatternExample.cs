using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{

    public interface Vechicle
    {
        string Make { get;  }
        string Model { get; }
        double Price { get; }
    }

    public class Honda : Vechicle
    {
        public string Make
        {
            get
            {
                return "HondaCity";
            }
        }

        public string Model
        {
            get
            {
                return "Non CNG";
            }
        }

        public double Price
        {
            get
            {
                return 1000000;
            }
        }
    }

    public abstract class VechicleDecorator : Vechicle
    {
        private Vechicle _vehicle;

        public VechicleDecorator(Vechicle vehicle)
        {
            this._vehicle = vehicle;
        }

        public string Make
        {
            get
            {
                return this._vehicle.Make;
            }
        }

        public string Model
        {
            get
            {
                return this._vehicle.Model;
            }
        }

        public double Price
        {
            get
            {
                return this._vehicle.Price;
            }
        }
    }

    public class SpecialOffer : VechicleDecorator
    {
        public SpecialOffer (Vechicle vehicle) : base(vehicle)
        {

        }

        public int DiscountPercentage { get; set; }

        public string Offer { get; set; }

        public new double Price
        {
            get {
                double price = base.Price;
                int percentage = 100 - DiscountPercentage;
                return Math.Round((price * percentage) / 100, 2);
            }
        }
    }

    class DecoratorPatternExample
    {
        //static void Main(string[] args)
        //{
        //    Honda car = new Honda();
        //    Console.WriteLine($"Honda City Base price is {car.Price}");

        //    SpecialOffer offer = new SpecialOffer(car);
        //    offer.DiscountPercentage = 25;
        //    offer.Offer = "25% Discount";

        //    Console.WriteLine($"{offer.Offer} @ Festival Special Offer and Price is: {offer.Price}");
        //    Console.Read();
        //}
    }
}
