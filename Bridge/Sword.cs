using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Sword : IWeapon
    {
        public IEnchantment Enchantment { get; set; }

        public Sword(IEnchantment enchantment = null)
        {
            Enchantment = enchantment;
        }

        public void Wield()
        {
            Console.WriteLine("The sword is wielded.");
            Enchantment?.onActivate();
        }

        public void Swing()
        {
            Console.WriteLine("The sword is swinged.");
            Enchantment?.apply();
        }

        public void Unwield()
        {
            Console.WriteLine("The sword is unwielded.");
            Enchantment?.onDeactivate();
        }
    }
}
