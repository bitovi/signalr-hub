using System.Collections.Generic;

namespace DoneChatServeR.Models
{
    public class ChatRoomViewModel
    {
        public string Topic { get; set; }
        public List<UserViewModel> Users { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRoomViewModel"/> class.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// <param name="users">The users.</param>
        public ChatRoomViewModel(string topic, List<UserViewModel> users)
        {
            Topic = topic;
            Users = users;
        }
    }
}