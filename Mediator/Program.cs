using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatRoom chatRoom = new ChatRoom();

            ChatRoomManager manager = new ChatRoomManager("Ackerley", chatRoom);
            User User1 = new User("Maaravi", chatRoom);
            User User2 = new User("Rachel", chatRoom);

            User1.Send("hi! Rachel");
            User2.Send("hi!");
            manager.Announce("Overload Season 3 is coming!");
            User1.Send("Cooooool!");
            User1.Leave();
            User1.Join(chatRoom);

            manager.DisplayScreen();
            User1.DisplayScreen();
            User2.DisplayScreen();
        }
    }
}
