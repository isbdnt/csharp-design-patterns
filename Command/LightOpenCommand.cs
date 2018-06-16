using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LightOpenCommand : ICommand
    {
        Light light;

        public LightOpenCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.PowerOn();
        }
    }
}
