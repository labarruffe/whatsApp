namespace whatsApp
{
    public class PhotoMessage : Message
    {
        public int Size { get; set; }

        public PhotoMessage(int size, Contact recipient, string sentTime, string content): base(recipient, sentTime, content)
        {
            this.Size = size;
        }
        
        public override string ToString()
        {
            return (
                base.ToString() +
                "Size: " + this.Size + "KB"
            );
        }
    }
}