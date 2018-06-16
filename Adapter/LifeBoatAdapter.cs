using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class LifeBoatAdapter : IRowingBoat
    {
        LifeBoat lifeBoat = new LifeBoat();

        public void Row()
        {
            lifeBoat.Row();
        }
    }
}
