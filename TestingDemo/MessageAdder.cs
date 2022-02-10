namespace TestingDemo
{
    public class MessageAdder : Sender
    {
        private readonly Sender _sender;

        public MessageAdder(Sender sender)
        {
            _sender = sender;
        }

        public bool IsMessageAdded(string message, string sender)
        {
            if (message.StartsWith("H") && WhoIs(sender)) return true;
            return false;

        }
    }
}
