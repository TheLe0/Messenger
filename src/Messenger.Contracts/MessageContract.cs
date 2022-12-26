namespace Messenger.Contracts
{
    public class MessageContract
    {
        public static readonly string Topic = "Messages";
        public string Id { get; set; }
        public string Content { get; set; }

        public MessageContract()
        {
            Id = Guid.NewGuid().ToString();
            Content = string.Empty;
        }

        public MessageContract(string content)
        {
            Id = Guid.NewGuid().ToString();
            Content = content;
        }

    }
}
