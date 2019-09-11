namespace whatsApp
{
    public abstract class Message
    {
        public Contact Recipient { get; set; }
        public string SentTime { get; set; }
        public string Content { get; set; }

        public Message(Contact recipient, string sentTime, string content)
        {
            this.Recipient = recipient;
            this.SentTime = sentTime;
            this.Content = content;
        }

        public override string ToString()
        {
            return (
                "\n" +
                "[" + this.SentTime + "]: " +
                "\n" +
                this.Recipient.Name + "-" + this.Recipient.Phone +
                "\n" +
                "-----------------------------------------------------" +
                "\n" +
                this.Content +
                "\n" +
                "-----------------------------------------------------" +
                "\n"
            );
        }
    }
}