using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Menu : IMenuComponent
    {
        static int Level = 0;

        List<IMenuComponent> menuComponents = new List<IMenuComponent>();

        public string Name { get; set; }

        public void Add(IMenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public void Display()
        {
            Level++;
            Console.WriteLine("Menu: " + Name);
            foreach (var menuComponent in menuComponents)
            {
                Console.Write(new String('\t', Level));
                menuComponent.Display();
                Console.Write("\n");
            }
            Level--;
        }
    }
}
