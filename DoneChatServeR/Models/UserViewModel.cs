namespace DoneChatServeR.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }

        public UserViewModel(string name)
        {
            Name = name;
        }
    }
}