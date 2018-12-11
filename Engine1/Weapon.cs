using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int MaximumDamage { get; set; }
        public int MinimumDamage { get; set; }

        public Weapon(int id, string name, string namePlural, int maximumDamage, int minimumDamage, int price) : base(id, name, namePlural, price)
        {
            MaximumDamage = maximumDamage;
            MinimumDamage = minimumDamage;
        }
    }
}