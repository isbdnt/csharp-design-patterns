using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class LowerCaseState : ICaseState
    {
        public void WriteName(StateContext context, String name)
        {
            Console.WriteLine(name.ToLower());
            context.SetState(new UpperCaseState());
        }
    }
}
