namespace DoneChatServeR.Models
{
    public class ChatUser
    {
        public string ConnectionId { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUser"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="connectionId">The connection identifier.</param>
        public ChatUser(string name, string connectionId)
        {
            Name = name;
            ConnectionId = connectionId;
        }
    }
}