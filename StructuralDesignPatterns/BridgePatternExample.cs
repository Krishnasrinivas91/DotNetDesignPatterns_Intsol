using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns
{

    public abstract class Message
    {
        public IMessageSender MessageSender { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public abstract void Send();
    }

    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }

    public class UserMessage : Message
    {
        public string UserComments { get; set; }

        public override void Send()
        {
            string fullbody = $"{Body} \n UserComments: {UserComments}";
            MessageSender.SendMessage(Subject, fullbody);
        }
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Subject : {subject}, Body : {body}");
        }
    }

    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Subject : {subject}, Body : {body}");
        }
    }

    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine($"Subject : {subject}, Body : {body}");
        }
    }

    class BridgePatternExample
    {
        //static void Main(string[] args)
        //{
        //    IMessageSender email = new EmailSender();
        //    IMessageSender msmq = new MSMQSender();
        //    IMessageSender web = new WebServiceSender();

        //    Message message = new SystemMessage();
        //    message.Subject = "Test Message";
        //    message.Body = "This is Test Message";

        //    message.MessageSender = email;
        //    message.Send();

        //    message.MessageSender = msmq;
        //    message.Send();

        //    message.MessageSender = web;
        //    message.Send();

        //    UserMessage userMessage = new UserMessage();
        //    userMessage.Subject = "User Message Subject";
        //    userMessage.Body = "This is user test message";
        //    userMessage.UserComments = "Acknowledged";
        //    userMessage.MessageSender = email;
        //    userMessage.Send();

        //    Console.Read();
        //}
    }
}
