using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class FlyingEnchantment : IEnchantment
    {
        public void apply()
        {
            Console.WriteLine("The item flies and strikes the enemies finally returning to owner's hand.");
        }

        public void onActivate()
        {
            Console.WriteLine("The item begins to glow faintly.");
        }

        public void onDeactivate()
        {
            Console.WriteLine("The item's glow fades.");
        }
    }
}
