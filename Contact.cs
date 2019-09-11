namespace whatsApp
{
    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }

        public Contact(string name, string phone)
        {
            this.Name = name;
            this.Phone = phone;
        }
    }
}