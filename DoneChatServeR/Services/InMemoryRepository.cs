using System.Collections.Concurrent;
using DoneChatServeR.Models;

namespace DoneChatServeR.Services
{
    public class InMemoryRepository : IDoneChatServeRRepository
    {
        public ConcurrentDictionary<string, ChatUser> Users { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryRepository"/> class.
        /// </summary>
        public InMemoryRepository()
        {
            Users = new ConcurrentDictionary<string, ChatUser>();
        }

        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ChatUser</returns>
        public ChatUser GetUserById(string id)
        {
            return Users[id];
        }

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(ChatUser user)
        {
            Users.TryAdd(user.ConnectionId, user);
        }

        /// <summary>
        /// Removes the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>The result of a deletion</returns>
        public ChatUser RemoveUser(string id)
        {
            ChatUser result;
            Users.TryRemove(id, out result);
            return result;
        }
    }
}