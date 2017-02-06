namespace DoneChatServeR.Models
{
    public class ChatUser
    {
        public string ConnectionId { get; set; }
        public string Name { get; set; }

        public ChatUser(string name, string connectionId)
        {
            Name = name;
            ConnectionId = connectionId;
        }
    }
}