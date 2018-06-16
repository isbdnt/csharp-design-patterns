using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        public void Operate()
        {
            AbstractMethod1();
            Console.WriteLine("AbstractClass operating");
            AbstractMethod2();
        }
        protected abstract void AbstractMethod1();
        protected abstract void AbstractMethod2();
    }
}
