using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class MenuItem : IMenuComponent
    {
        public string Name { get; set; }

        public void Display()
        {
            Console.Write("MenuItem: " + Name);
        }
    }
}
