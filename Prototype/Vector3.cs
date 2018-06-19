using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    [Serializable]
    struct Vector3
    {
        public float X;
        public float Y;
        public float Z;

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            return lhs.X == rhs.X && lhs.Y == rhs.Y && lhs.Z == rhs.Z;
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return !(lhs == rhs);
        }
    }
}
