using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class OrcWeaponFactory : IWeaponFactory
    {
        public Weapon CreateWeapon(WeaponType weaponType)
        {
            Weapon weapon = null;
            switch (weaponType)
            {
                case WeaponType.Sword:
                    weapon = new OrcSword();
                    break;
                case WeaponType.Axe:
                    weapon = new OrcAxe();
                    break;
                default:
                    break;
            }
            return weapon;
        }
    }
}
