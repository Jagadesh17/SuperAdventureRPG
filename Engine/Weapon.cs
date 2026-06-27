using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
       
        public int MinimumDamage { get; set; } // Property to hold the minimum damage the weapon can inflict
        public int MaximumDamage { get; set; } // Property to hold the maximum damage the weapon can inflict

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage) : base(id, name, namePlural)
        {
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
