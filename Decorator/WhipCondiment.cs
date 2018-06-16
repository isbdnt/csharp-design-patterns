using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class WhipCondiment : IBeverage
    {
        public string Description =>
            beverage.Description.StartsWith("Whip") ?
            "Double " + beverage.Description : "Whip " + beverage.Description;

        IBeverage beverage;

        public WhipCondiment(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public float Cost()
        {
            return 0.15f + beverage.Cost();
        }
    }
}
