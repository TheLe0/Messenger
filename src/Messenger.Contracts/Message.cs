namespace Messenger.Contracts
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        public Message()
        {
            Id = Guid.NewGuid();
            Content = string.Empty;
        }

        public Message(string conttent)
        {
            Id = Guid.NewGuid();
            Content = conttent;
        }
    }
}