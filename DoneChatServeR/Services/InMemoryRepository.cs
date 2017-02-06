using System.Collections.Concurrent;
using DoneChatServeR.Models;

namespace DoneChatServeR.Services
{
    public class InMemoryRepository : IDoneChatServeRRepository
    {
        public ConcurrentDictionary<string, ChatUser> Users { get; set; }

        public InMemoryRepository()
        {
            Users = new ConcurrentDictionary<string, ChatUser>();
        }

        public ChatUser GetUserById(string id)
        {
            return Users[id];
        }

        public void AddUser(ChatUser user)
        {
            Users.TryAdd(user.ConnectionId, user);
        }

        public ChatUser RemoveUser(string id)
        {
            ChatUser result;
            Users.TryRemove(id, out result);
            return result;
        }
    }
}