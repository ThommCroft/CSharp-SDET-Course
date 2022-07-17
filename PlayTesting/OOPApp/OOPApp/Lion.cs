using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Lion : BaseAnimal, IAttackable // Sub Class
    {
        public IAttackable Weapon{ get; set; }

        public Lion(string name,  IAttackable weapon) : base(name, "Lion")
        {
            Weapon = weapon;
        }

        public override string Move()
        {
            return base.Move();
        }

        public override string Eat(string food)
        {
            return base.Eat(food);
        }

        public string Attack()
        {
            return $"{Name} used {Weapon}";
        }
    }
}
