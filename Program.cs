using System;

namespace whatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating an Whatsapp...");
            Whatsapp whatsapp = new Whatsapp();
            
            Console.WriteLine("Add new contact:");
            Console.WriteLine("Name ?");
            string name = Console.ReadLine();
            Console.WriteLine("Phone number ?");
            string phone = Console.ReadLine();

            Contact newContact = whatsapp.CreateContact(name, phone); 

            Console.WriteLine("Send as SMS, Audio or Photo ?");
            string messageType = Console.ReadLine();
            Console.WriteLine("Write you content:");
            string content = Console.ReadLine();
            
            Message newMessage = whatsapp.SendMessage(newContact, messageType, content);

            Console.WriteLine(newMessage);
        }
    }
}
