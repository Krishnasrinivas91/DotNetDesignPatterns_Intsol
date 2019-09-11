using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns
{
    //Mediator Interface
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string message, IUser user);
    }

    //ConcreteMediator Class
    class ChatMediator : IChatMediator
    {
        List<IUser> users;
        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser sender)
        {
            foreach(var each in users)
            {
                if (each != sender)
                    each.RecieveMessage(message);
            }
        }
    }

    public interface IUser
    {
        void SendMessage(string message);
        void RecieveMessage(string message);
    }

    public class BasicUser : IUser
    {
        string name;
        IChatMediator chatMediator;
        public BasicUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }
        public void RecieveMessage(string message)
        {
            Console.WriteLine($"User Type : Basic, User Name : {this.name}, Message : {message}");
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }
    }

    public class PremiumUser : IUser
    {
        string name;
        IChatMediator chatMediator;
        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }
        public void RecieveMessage(string message)
        {
            Console.WriteLine($"User Type : Premium, User Name : {this.name}, Message : {message}");
        }

        public void SendMessage(string message)
        {
            chatMediator.SendMessage(message, this);
        }
    }
    class MediatorPatternExample
    {
        //static void Main(string[] args)
        //{
        //    IChatMediator chatMediator = new ChatMediator();
        //    IUser king = new BasicUser(chatMediator, "King");
        //    IUser Kochhar = new BasicUser(chatMediator, "Kochhar");
        //    IUser John = new PremiumUser(chatMediator, "John");
        //    IUser Smith = new PremiumUser(chatMediator, "Smith");

        //    chatMediator.AddUser(king);
        //    chatMediator.AddUser(Kochhar);
        //    chatMediator.AddUser(John);
        //    chatMediator.AddUser(Smith);

        //    king.SendMessage("Hello Everyone");

        //    Console.Read();
        //}
    }
}
