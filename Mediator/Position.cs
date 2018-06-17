using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    struct Position
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"x: {X}, y: {Y}";
        }
        public static Position operator -(Position a, Position b)
        {
            return new Position()
            {
                X = a.X - a.X,
                Y = b.Y - b.Y,
            };
        }
    }
}
