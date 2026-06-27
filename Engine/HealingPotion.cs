using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class HealingPotion: Item
    {
       
        public int AmountToHeal { get; set; } // Property to hold the amount of hit points the potion heals
        
        public HealingPotion(int id, string name, string namePlural, int amountToHeal) : base(id, name, namePlural)
        {
            AmountToHeal = amountToHeal;
        }
    }
}
