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

        public MessageHub(IDoneChatServeRRepository repository)
        {
            _repository = repository;
        }

        public ChatMessageViewModel MessageCreate(MessageViewModel message)
        {
            Random rand = new Random();
            int messageId = rand.Next();
            ChatMessageViewModel chatVm = new ChatMessageViewModel(new UserViewModel(message.name), message.body, messageId);
            Clients.All.messageCreated(chatVm);

            return chatVm;
        }

        public List<ChatMessageViewModel> MessageGetList(string name, string msg)
        {
            List<ChatMessageViewModel> items = new List<ChatMessageViewModel>(new ChatMessageViewModel[] {
                new ChatMessageViewModel(new UserViewModel("Test"), "one", 1),
                new ChatMessageViewModel(new UserViewModel("this"), "two", 2),
                new ChatMessageViewModel(new UserViewModel("again"), "three", 3)
            });

            return items;
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            _repository.RemoveUser(Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}