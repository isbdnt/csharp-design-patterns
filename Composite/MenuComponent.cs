using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    interface IMenuComponent
    {
        string Name { get; set; }
        void Display();
    }
}
