namespace DoneChatServeR.Models
{
    public class MessageViewModel
    {
        public string Name { get; set; }
        public string Body { get; set; }

        public MessageViewModel(string name, string body)
        {
            Name = name;
            Body = body;
        }
    }
}