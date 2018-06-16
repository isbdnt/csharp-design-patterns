using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class MochaCondiment : IBeverage
    {
        public string Description =>
            beverage.Description.StartsWith("Mocha") ?
            "Double " + beverage.Description : "Mocha " + beverage.Description;

        IBeverage beverage;

        public MochaCondiment(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public float Cost()
        {
            return 0.2f + beverage.Cost();
        }
    }
}
