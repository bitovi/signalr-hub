using DoneChatServeR.Models;
using DoneChatServeR.Services;
using Microsoft.AspNet.SignalR;

namespace DoneChatServeR.Hubs
{
    public class DoneChatHub : Hub
    {
        private readonly IDoneChatServeRRepository _repository;

        public DoneChatHub(IDoneChatServeRRepository repository)
        {
            _repository = repository;
        }

        public void SendChat(string name, string msg)
        {
            ChatMessageViewModel chatVm = new ChatMessageViewModel(new UserViewModel(name), msg, 1);
            Clients.All.chatBroadcast(chatVm);
        }


        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            _repository.RemoveUser(Context.ConnectionId);
            return base.OnDisconnected(stopCalled);
        }
    }
}