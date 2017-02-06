using System.Collections.Concurrent;
using DoneChatServeR.Models;

namespace DoneChatServeR.Services
{
    public interface IDoneChatServeRRepository
    {
        ConcurrentDictionary<string, ChatUser> Users { get; set; }

        ChatUser GetUserById(string id);

        void AddUser(ChatUser user);

        ChatUser RemoveUser(string id);
    }
}