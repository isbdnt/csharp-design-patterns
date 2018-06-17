using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Car
    {
        public string Owner;
        public string Color;
        public CarModel Model;

        public override string ToString()
        {
            return $"ExtrinsicState:\n\tOwner: {Owner}, Color: {Color},\nIntrinsicState:\n\tBrand: {Model.Brand}, Price: {Model.Price}";
        }
    }
}
