using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{

    public interface IShape
    {
        void Print();
    }

    class Rectangle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Rectangle ...");
        }
    }

    class Circle : IShape
    {
        public void Print()
        {
            Console.WriteLine("Printing Circle ...");
        }
    }

    class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();
        public int TotalObjectsCreate
        {
            get
            {
                return shapes.Count;
            }
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape = null;
            if (shapes.ContainsKey(ShapeName))
                shape = shapes[ShapeName];
            else
                switch(ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified...");
                }

            return shape;
        }
    }

    class FlyWeightPatternExample
    {
        //static void Main(string[] args)
        //{
        //    ShapeObjectFactory sof = new ShapeObjectFactory();

        //    IShape shape = sof.GetShape("Rectangle");
        //    shape.Print();
        //    shape = sof.GetShape("Rectangle");
        //    shape.Print();
        //    shape = sof.GetShape("Rectangle");
        //    shape.Print();

        //    shape = sof.GetShape("Circle");
        //    shape.Print();
        //    shape = sof.GetShape("Circle");
        //    shape.Print();
        //    shape = sof.GetShape("Circle");
        //    shape.Print();

        //    int NumObjs = sof.TotalObjectsCreate;
        //    Console.WriteLine($"\nTotal Number of Objects created {NumObjs}");

        //    Console.ReadLine();
        //}
    }
}
