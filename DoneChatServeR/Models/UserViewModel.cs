namespace DoneChatServeR.Models
{
    public class UserViewModel
    {
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserViewModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public UserViewModel(string name)
        {
            Name = name;
        }
    }
}