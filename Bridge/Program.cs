using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon myWeapon = new Sword(new SoulEatingEnchantment());
            myWeapon.Wield();
            myWeapon.Swing();
            myWeapon.Unwield();

            Console.WriteLine();
            Console.WriteLine("change weapon");
            Console.WriteLine();

            myWeapon = new Hammer(new FlyingEnchantment());
            myWeapon.Wield();
            myWeapon.Swing();
            myWeapon.Unwield();
        }
    }
}
