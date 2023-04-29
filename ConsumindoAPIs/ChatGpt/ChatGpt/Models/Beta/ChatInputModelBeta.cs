namespace ChatGpt.Models.Beta
{

    public class ChatInputModelBeta
    {
        public ChatInputModelBeta(string prompt)
        {
            messages.Add(new Message { role = "user", content = prompt });
            model = "gpt-3.5-turbo";

        }
        public string model { get; set; }
        public List<Message> messages { get; set; } = new List<Message>();
    }
}
