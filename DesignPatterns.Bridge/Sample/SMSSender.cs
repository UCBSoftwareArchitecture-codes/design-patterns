using System;

namespace DesignPatterns.Bridge.Sample
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("SMS\n{0}\n{1}\n", subject, body);
        }
    }
}