using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu()
            {
                Name = "main"
            };
            Menu subMenu = new Menu()
            {
                Name = "sub"
            };
            mainMenu.Add(new MenuItem() { Name = "Item1" });
            mainMenu.Add(new MenuItem() { Name = "Item2" });

            subMenu.Add(new MenuItem() { Name = "SubItem1" });
            subMenu.Add(new MenuItem() { Name = "SubItem2" });
            mainMenu.Add(subMenu);

            mainMenu.Add(new MenuItem() { Name = "Item3" });

            mainMenu.Display();
        }
    }
}
