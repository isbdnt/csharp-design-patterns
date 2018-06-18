using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            AvatarCropping avatarCropping = new AvatarCropping(new Image());
            avatarCropping.SaveToMemento("Initial");

            Console.WriteLine(avatarCropping.ToString());
            Console.WriteLine();
            Console.WriteLine("user began editing");
            avatarCropping.Resize(120, 160);
            avatarCropping.MoveTo(50, 60);
            Console.WriteLine(avatarCropping.ToString());
            Console.WriteLine("user ended editing");
            Console.WriteLine();
            Console.WriteLine("user clicked reset");
            avatarCropping.RestoreFromMemento("Initial");
            Console.WriteLine(avatarCropping.ToString());
        }
    }
}
