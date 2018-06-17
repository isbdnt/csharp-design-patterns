using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class User
    {
        public string Name { get; }

        protected ChatRoom chatRoom;
        string messages;

        public User(string name, ChatRoom chatRoom = null)
        {
            Name = name;
            this.chatRoom = chatRoom;
            chatRoom?.Join(this);
        }

        public void Receive(string message, string from)
        {
            messages += $"{from}: {message}\n";
        }

        public void Send(string message)
        {
            chatRoom?.Send(this, message);
        }

        public void DisplayScreen()
        {
            Console.WriteLine($"{Name}'s screen");
            Console.WriteLine(messages);
        }

        public void Leave()
        {
            chatRoom?.Leave(this);
            chatRoom = null;
        }

        public void Join(ChatRoom chatRoom)
        {
            this.chatRoom = chatRoom;
            chatRoom.Join(this);
        }
    }
}
