using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class UpperCaseState : ICaseState
    {
        int count = 0;

        public void WriteName(StateContext context, String name)
        {
            Console.WriteLine(name.ToUpper());
            if (++count > 1)
            {
                context.SetState(new LowerCaseState());
            }
        }
    }
}
