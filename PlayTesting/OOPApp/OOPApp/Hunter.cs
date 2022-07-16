using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Hunter : Human // Sub Class of a Sub Class
    {
        public IAttackable Weapon { get; set; }

        public Hunter(string name, string animalType, IAttackable weapon) : base(name, animalType)
        {
            Weapon = weapon;
        }

        public override string Attack()
        {
            return $"{Name} used {Weapon}";
        }
    }
}
