using DoneChatServeR.Models;
using DoneChatServeR.Services;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;

namespace DoneChatServeR.Hubs
{
    public class MessageHub : Hub
    {
        private readonly IDoneChatServeRRepository _repository;
        public List<MessageViewModel> items { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageHub"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public MessageHub(IDoneChatServeRRepository repository)
        {
            _repository = repository;
            items = new List<MessageViewModel>(new MessageViewModel[] {});
        }

        /// <summary>
        /// Creates a message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>MessageViewModel</returns>
        public MessageViewModel MessageHubCreate(MessageViewModel message)
        {
            Random rand = new Random();
            message.id = rand.Next();
            Clients.All.messageHubCreated(message);

            return message;
        }

        /// <summary>
        /// Updates a message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>MessageViewModel</returns>
        public MessageViewModel MessageHubUpdate(MessageViewModel message)
        {
            Clients.All.messageHubUpdated(message);
            return message;
        }

        /// <summary>
        /// Destroys a message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>MessageViewModel</returns>
        public MessageViewModel MessageHubDestroy(MessageViewModel message)
        {
            Clients.All.messageHubDestroyed(message);
            return message;
        }

        /// <summary>
        /// Gets list data.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>List of MessageViewModel</returns>
        public List<MessageViewModel> MessageHubGetListData(MessageViewModel message)
        {
            return items;
        }

        /// <summary>
        /// Called when a connection disconnects from this hub gracefully or due to a timeout.
        /// </summary>
        /// <param name="stopCalled">true, if stop was called on the client closing the connection gracefully;
        /// false, if the connection has been lost for longer than the
        /// <see cref="P:Microsoft.AspNet.SignalR.Configuration.IConfigurationManager.DisconnectTimeout" />.
        /// Timeouts can be caused by clients reconnecting to another SignalR server in scaleout.</param>
        /// <returns>
        /// A <see cref="T:System.Threading.Tasks.Task" />
        /// </returns>
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            _repository.RemoveUser(Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}