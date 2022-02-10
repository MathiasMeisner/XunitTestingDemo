namespace TestingDemo
{
    public class MessageAdder : ISender
    {

        public bool WhoIs(string sender)
        {
            if (sender == "Mathias") return true;
                return false;
            

        }

        public bool IsMessageAdded(string message, string sender)
        {
            if (message.StartsWith("H") && WhoIs(sender)) return true;
            return false;

        }
    }
}
