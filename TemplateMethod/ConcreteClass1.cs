using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass1 : AbstractClass
    {
        protected override void AbstractMethod1()
        {
            Console.WriteLine("ConcreteClass1 method1");
        }

        protected override void AbstractMethod2()
        {
            Console.WriteLine("ConcreteClass1 method2");
        }
    }
}
