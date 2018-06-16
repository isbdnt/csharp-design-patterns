using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class GarageDoorOpenCommand : ICommand
    {
        Garage garage;

        public GarageDoorOpenCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void Execute()
        {
            garage.OpenDoor();
        }
    }
}
