using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ChatRoom
    {
        List<User> users = new List<User>();

        public void Join(User who)
        {
            foreach (var user in users)
            {
                user.Receive($"{who.Name} joined", "system");
            }
            users.Add(who);
        }

        public void Leave(User who)
        {
            users.Remove(who);
            foreach (var user in users)
            {
                user.Receive($"{who.Name} leaved", "system");
            }
        }

        public void Send(User who, string message)
        {
            foreach (var user in users)
            {
                user.Receive(message, who.Name);
            }
        }

        public void Announce(ChatRoomManager manager, string message)
        {
            foreach (var user in users)
            {
                user.Receive(message, "system");
            }
        }
    }
}
