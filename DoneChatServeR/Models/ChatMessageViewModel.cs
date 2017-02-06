namespace DoneChatServeR.Models
{
    public class ChatMessageViewModel
    {
        public string name;
        public string message;
        public int id;
        

        public ChatMessageViewModel(UserViewModel sender, string body, int messageId)
        {
            name = sender.Name;
            message = body;
            id = messageId;
        }
    }
}