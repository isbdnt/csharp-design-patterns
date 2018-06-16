using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Espresso : IBeverage
    {
        public string Description => "Espresso";

        public float Cost()
        {
            return 2.99f;
        }
    }
}
