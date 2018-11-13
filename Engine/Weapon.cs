using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Weapon : Item
    {
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
    }
}