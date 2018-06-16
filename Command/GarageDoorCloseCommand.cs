using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class GarageDoorCloseCommand : ICommand
    {
        Garage garage;

        public GarageDoorCloseCommand(Garage garage)
        {
            this.garage = garage;
        }

        public void Execute()
        {
            garage.CloseDoor();
        }
    }
}
