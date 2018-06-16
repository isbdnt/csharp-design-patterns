using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IRowingBoat boat1 = new FishingBoatAdapter();
            IRowingBoat boat2 = new LifeBoatAdapter();
            boat1.Row();
            boat2.Row();
        }
    }
}
