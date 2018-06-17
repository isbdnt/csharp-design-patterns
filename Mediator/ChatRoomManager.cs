using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class ChatRoomManager : User
    {
        public ChatRoomManager(string name, ChatRoom chatRoom) : base(name, chatRoom)
        {

        }

        public void Announce(string message)
        {
            chatRoom.Announce(this, message);
        }
    }
}
