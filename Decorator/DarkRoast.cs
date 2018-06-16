using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class DarkRoast : IBeverage
    {
        public string Description => "Dark Roast";

        public float Cost()
        {
            return 1.99f;
        }
    }
}
