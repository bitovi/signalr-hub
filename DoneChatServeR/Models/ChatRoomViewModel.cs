using System.Collections.Generic;

namespace DoneChatServeR.Models
{
    public class ChatRoomViewModel
    {
        public string Topic { get; set; }
        public List<UserViewModel> Users { get; set; }

        public ChatRoomViewModel(string topic, List<UserViewModel> users)
        {
            Topic = topic;
            Users = users;
        }
    }
}