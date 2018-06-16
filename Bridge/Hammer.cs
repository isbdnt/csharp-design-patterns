using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Hammer : IWeapon
    {
        public IEnchantment Enchantment { get; set; }

        public Hammer(IEnchantment enchantment = null)
        {
            Enchantment = enchantment;
        }

        public void Wield()
        {
            Console.WriteLine("The hammer is wielded.");
            Enchantment?.onActivate();
        }

        public void Swing()
        {
            Console.WriteLine("The hammer is swinged.");
            Enchantment?.apply();
        }

        public void Unwield()
        {
            Console.WriteLine("The hammer is unwielded.");
            Enchantment?.onDeactivate();
        }
    }
}
