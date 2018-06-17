using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    static class MathHelper
    {
        public static double Length(Position direction)
        {
            return Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
        }
    }
}
