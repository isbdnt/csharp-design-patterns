using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass2 : AbstractClass
    {
        protected override void AbstractMethod1()
        {
            Console.WriteLine("ConcreteClass2 method1");
        }

        protected override void AbstractMethod2()
        {
            Console.WriteLine("ConcreteClass2 method2");
        }
    }
}
