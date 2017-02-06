namespace DoneChatServeR.Models
{
    public class MessageViewModel
    {
        public string name { get; set; }
        public string body { get; set; }

        public MessageViewModel(string name, string body)
        {
            this.name = name;
            this.body = body;
        }
    }
}