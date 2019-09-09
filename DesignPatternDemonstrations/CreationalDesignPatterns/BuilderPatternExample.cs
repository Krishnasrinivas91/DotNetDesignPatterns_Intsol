using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    class Laptop
    {
        public string ModelNumber { get; set; }
        public string Display { get; set; }
        public string RAM { get; set; }
        public string GraphicsCard { get; set; }

        public string TouchScreen { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("**** Laptop Details ********");
            Console.WriteLine($"Model Number : {ModelNumber}");
            Console.WriteLine($"Display : {Display}");
            Console.WriteLine($"RAM : {RAM}");
            Console.WriteLine($"Graphics Card : {GraphicsCard}");
            Console.WriteLine($"Touch Screen : {TouchScreen}");
        }
    }

    interface ILaptopBuilder
    {
        void AddModelNumber();
        void AddDisplay();
        void AddRAM();
        void AddGraphicCard();
        void AddTouchScreen();

        Laptop GetLaptop();
    }

    class GamingLaptopBuilder : ILaptopBuilder
    {
        Laptop laptop = new Laptop();
        public void AddDisplay()
        {
            laptop.Display = "Full HD Display";
        }

        public void AddGraphicCard()
        {
            laptop.GraphicsCard = "Nvidia";
        }

        public void AddModelNumber()
        {
            laptop.ModelNumber = "GAMING1001";
        }

        public void AddRAM()
        {
            laptop.RAM = "16GB";
        }

        public void AddTouchScreen()
        {
            laptop.TouchScreen = "Yes";
        }

        public Laptop GetLaptop()
        {
            return laptop;
        }
    }

    class NormalLaptop : ILaptopBuilder
    {
        Laptop laptop = new Laptop();
        public void AddDisplay()
        {
            laptop.Display = "HD Display";
        }

        public void AddGraphicCard()
        {
            laptop.GraphicsCard = "No Graphic Card";
        }

        public void AddModelNumber()
        {
            laptop.ModelNumber = "Normal1001";
        }

        public void AddRAM()
        {
            laptop.RAM = "2GB";
        }

        public void AddTouchScreen()
        {
            laptop.TouchScreen = "No";
        }

        public Laptop GetLaptop()
        {
            return laptop;
        }
    }

    class LaptopManufacturer
    {
        public void BuildLaptop(ILaptopBuilder laptopBuilder)
        {
            laptopBuilder.AddModelNumber();
            laptopBuilder.AddDisplay();
            laptopBuilder.AddRAM();
            laptopBuilder.AddGraphicCard();
            laptopBuilder.AddTouchScreen();
        }
    }

    class BuilderPatternExample
    {
        //static void Main(string[] args)
        //{
        //    LaptopManufacturer laptopManufacturer = new LaptopManufacturer();
        //    ILaptopBuilder gamingLaptop = new GamingLaptopBuilder();
        //    laptopManufacturer.BuildLaptop(gamingLaptop);
        //    var laptop = gamingLaptop.GetLaptop();
        //    Console.WriteLine(laptop.ModelNumber);
        //    Console.Read();
        //}
    }
}
