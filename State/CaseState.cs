using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    interface ICaseState
    {
        void WriteName(StateContext context, String name);
    }
}
