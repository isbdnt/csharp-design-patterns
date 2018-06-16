using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass1 = new ConcreteClass1();
            AbstractClass abstractClass2 = new ConcreteClass2();

            abstractClass1.Operate();
            Console.WriteLine();
            abstractClass2.Operate();
        }
    }
}
