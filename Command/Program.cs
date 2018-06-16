using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Garage garage = new Garage();

            Switch theSwitch = new Switch(new LightOpenCommand(light), new LightCloseCommand(light));
            Switch anotherSwitch = new Switch(new GarageDoorOpenCommand(garage), new GarageDoorCloseCommand(garage));

            theSwitch.Open();
            theSwitch.Close();

            anotherSwitch.Open();
            anotherSwitch.Close();
        }
    }
}
