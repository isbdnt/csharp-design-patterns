using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject go1 = new GameObject();
            Transform tsfm1 = go1.AddComponent<Transform>();
            tsfm1.Position = new Vector3()
            {
                X = 1,
                Y = 2,
                Z = 0,
            };
            Rigidbody rb1 = go1.AddComponent<Rigidbody>();
            rb1.Mass = 50;

            GameObject go2 = GameObject.Instantiate(go1);
            Transform tsfm2 = go2.GetComponent<Transform>();
            Rigidbody rb2 = go2.GetComponent<Rigidbody>();

            Console.WriteLine(tsfm1 == tsfm2);
            Console.WriteLine(tsfm1.Position == tsfm2.Position);

            Console.WriteLine(rb1 == rb2);
            Console.WriteLine(rb1.Mass == rb2.Mass);
        }
    }
}
