using System;
using System.Collections.Generic;

namespace whatsApp
{
    public class Whatsapp
    {
        public List<Contact> ContactList { get; set; }
        public List<Message> MessageList { get; set; }

        public Whatsapp()
        {
            this.ContactList = new List<Contact>();
            this.MessageList = new List<Message>();
        }
        public void ListAllContacts()
        {
            foreach(Contact contact in ContactList)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        public void ListAllMessages()
        {
            foreach(Message message in MessageList)
                Console.WriteLine(message.ToString());
        }

        public Contact CreateContact(string name, string phone) {
            Contact contact = new Contact(name, phone);
            this.ContactList.Add(contact);
            return contact;
        }

        public Message SendMessage(Contact recipient, string type, string content) {
            string timeNow = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            int extraInfo = new Random().Next(1000);

            if (this.ContactList.Count == 0)
            {
                Console.WriteLine("Your contact list is empty!");
                return null;
            }
            else
            {            
                switch (type)
                {
                    case "SMS":
                        TextMessage textMessage = new TextMessage(extraInfo, recipient, timeNow, content);
                        this.MessageList.Add(textMessage);
                        return textMessage;
                    case "Audio":
                        AudioMessage audioMessage = new AudioMessage(extraInfo, recipient, timeNow, content);
                        this.MessageList.Add(audioMessage);
                        return audioMessage;
                    case "Photo":
                        PhotoMessage photoMessage = new PhotoMessage(extraInfo, recipient, timeNow, content);
                        this.MessageList.Add(photoMessage);
                        return photoMessage;
                    default:
                        Console.WriteLine("Message type is invalid!");
                        return null;
                }
            }
        }
    }
}