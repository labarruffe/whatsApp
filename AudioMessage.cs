namespace whatsApp
{
    public class AudioMessage : Message
    {
        public int Duration { get; set; }

        public AudioMessage(int duration, Contact recipient, string sentTime, string content): base(recipient, sentTime, content)
        {
            this.Duration = duration;
        }

        public override string ToString()
        {
            return (
                base.ToString() +
                "Duration: " + this.Duration + " seconds"
            );
        }
    }
}