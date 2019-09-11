namespace whatsApp
{
    public class TextMessage : Message
    {
        public int NumChar { get; set; }

        public TextMessage(int numChar, Contact recipient, string sentTime, string content): base(recipient, sentTime, content)
        {
            this.NumChar = numChar;
        }

        public override string ToString()
        {
            return (
                base.ToString() +
                "Max Lenght Allowed: " + this.NumChar + " characters"
            );
        }
    }
}