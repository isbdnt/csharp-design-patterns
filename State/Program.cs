using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            StateContext stateContext = new StateContext();

            stateContext.WriteName("Monday");
            stateContext.WriteName("Tuesday");
            stateContext.WriteName("Wednesday");
            stateContext.WriteName("Thursday");
            stateContext.WriteName("Friday");
            stateContext.WriteName("Saturday");
            stateContext.WriteName("Sunday");
        }
    }
}
