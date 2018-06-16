using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Dimmer
    {
        public void Dim(int val)
        {
            Console.WriteLine(val == 10 ? "Turning Lights On" : $"Dimming lights to {val}");
        }

        public void Off() => Console.WriteLine("Switching off lights");
    }
}
