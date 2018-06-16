using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface IWeapon 
    {
        IEnchantment Enchantment { get; set; }
        void Wield();
        void Swing();
        void Unwield();
    }
}
