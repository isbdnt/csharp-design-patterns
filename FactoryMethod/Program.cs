using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon1 = WeaponFactory.CreateWeapon(WeaponType.Axe);
            Weapon weapon2 = WeaponFactory.CreateWeapon(WeaponType.Sword);

            Console.WriteLine("weapon1 is " + weapon1.GetType());
            Console.WriteLine("weapon2 is " + weapon2.GetType());
        }
    }
}
