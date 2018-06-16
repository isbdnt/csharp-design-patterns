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
            IWeaponFactory factory1 = new ElfWeaponFactory();
            IWeaponFactory factory2 = new OrcWeaponFactory();

            Weapon weapon1 = factory1.CreateWeapon(WeaponType.Axe);
            Weapon weapon2 = factory1.CreateWeapon(WeaponType.Sword);
            Weapon weapon3 = factory2.CreateWeapon(WeaponType.Axe);
            Weapon weapon4 = factory2.CreateWeapon(WeaponType.Sword);

            Console.WriteLine("weapon1 is " + weapon1.GetType());
            Console.WriteLine("weapon2 is " + weapon2.GetType());
            Console.WriteLine("weapon3 is " + weapon3.GetType());
            Console.WriteLine("weapon4 is " + weapon4.GetType());
        }
    }
}
