using System.Collections.Concurrent;
using DoneChatServeR.Models;

namespace DoneChatServeR.Services
{
    public interface IDoneChatServeRRepository
    {
        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        ConcurrentDictionary<string, ChatUser> Users { get; set; }

        /// <summary>
        /// Gets the user by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>ChatUser</returns>
        ChatUser GetUserById(string id);

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        void AddUser(ChatUser user);

        /// <summary>
        /// Removes the user.
        /// </summary>
        /// <param name="id">The identifier.</param>
        ChatUser RemoveUser(string id);
    }
}