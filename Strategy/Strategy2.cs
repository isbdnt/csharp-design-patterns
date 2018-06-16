using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Strategy2 : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy2");
        }
    }
}
