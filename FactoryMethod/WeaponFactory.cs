using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    static class WeaponFactory
    {
        public static Weapon CreateWeapon(WeaponType weaponType)
        {
            Weapon weapon = null;
            switch (weaponType)
            {
                case WeaponType.Sword:
                    weapon = new Sword();
                    break;
                case WeaponType.Axe:
                    weapon = new Axe();
                    break;
                default:
                    break;
            }
            return weapon;
        }
    }
}
