using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage beverage1 = new DarkRoast();
            beverage1 = new MochaCondiment(beverage1);
            beverage1 = new MochaCondiment(beverage1);
            beverage1 = new WhipCondiment(beverage1);
            Console.WriteLine(beverage1.Description + " $" + beverage1.Cost());

            IBeverage beverage2 = new Espresso();
            beverage2 = new MochaCondiment(beverage2);
            beverage2 = new WhipCondiment(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.Cost());
        }
    }
}
