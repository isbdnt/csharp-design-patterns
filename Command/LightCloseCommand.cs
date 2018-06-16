using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class LightCloseCommand : ICommand
    {
        Light light;

        public LightCloseCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.PowerOff();
        }
    }
}
