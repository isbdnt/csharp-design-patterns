using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ElfWeaponFactory : IWeaponFactory
    {
        public Weapon CreateWeapon(WeaponType weaponType)
        {
            Weapon weapon = null;
            switch (weaponType)
            {
                case WeaponType.Sword:
                    weapon = new ElfSword();
                    break;
                case WeaponType.Axe:
                    weapon = new ElfAxe();
                    break;
                default:
                    break;
            }
            return weapon;
        }
    }
}
