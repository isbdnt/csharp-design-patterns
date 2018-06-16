using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class SoulEatingEnchantment : IEnchantment
    {
        public void apply()
        {
            Console.WriteLine("The item eats the soul of enemies.");
        }

        public void onActivate()
        {
            Console.WriteLine("The item spreads bloodlust.");
        }

        public void onDeactivate()
        {
            Console.WriteLine("Bloodlust slowly disappears.");
        }
    }
}
