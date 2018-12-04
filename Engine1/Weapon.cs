using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int maxDamage, int minDamage) : base(id, name, namePlural)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
        }
    }
}