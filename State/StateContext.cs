using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class StateContext
    {
        ICaseState currentState;

        public StateContext()
        {
            SetState(new LowerCaseState());
        }

        public void SetState(ICaseState newState)
        {
            currentState = newState;
        }

        public void WriteName(String name)
        {
            currentState.WriteName(this, name);
        }
    }
}
