namespace DesignPatterns.Bridge.Sample
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}