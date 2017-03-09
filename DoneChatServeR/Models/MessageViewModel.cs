namespace DoneChatServeR.Models
{
    public class MessageViewModel
    {
        public string name { get; set; }
        public string message { get; set; }
        public int? id { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageViewModel"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="message">The message.</param>
        /// <param name="id">The identifier.</param>
        public MessageViewModel(string name, string message, int? id)
        {
            this.name = name;
            this.message = message;
            this.id = id;
        }

    }
}