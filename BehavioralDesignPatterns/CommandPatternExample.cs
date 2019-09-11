using System;
using System.Collections.Generic;

namespace BehavioralDesignPatterns
{
    //Command interface
    public interface ICommand
    {
        void Execute();
    }

    //Invoker class
    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();
        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }

    //Reciever Class
    public class Light
    {
        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }

        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }
    }

    //Concrete Command Class
    public class FlipUpCommand : ICommand
    {
        private Light _light;
        public FlipUpCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOn();
        }
    }

    //Concrete Command Class
    public class FlipDownCommand : ICommand
    {
        private Light _light;
        public FlipDownCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.TurnOff();
        }
    }

    class CommandPatternExample
    {     

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter Commands(ON/OFF) :");
        //    string cmd = Console.ReadLine();

        //    Light obj = new Light();
        //    ICommand switchUp = new FlipUpCommand(obj);
        //    ICommand switchDown = new FlipDownCommand(obj);

        //    Switch s = new Switch();
        //    if (cmd.ToLower() == "on")
        //        s.StoreAndExecute(switchUp);
        //    else if (cmd.ToLower() == "off")
        //        s.StoreAndExecute(switchDown);
        //    else
        //        Console.WriteLine("Provide Proper Command");


        //    Console.Read();
        //}
    }
}
