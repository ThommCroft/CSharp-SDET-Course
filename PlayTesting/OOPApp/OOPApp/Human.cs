using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Human : BaseAnimal, IAttackable // Sub Class
    {
        public IAttackable Weapon { get; set; }

        public Human(string name, IAttackable weapon) : base(name, "Human")
        {
            Weapon = weapon;
        }

        public override string Move() // Polymorphism
        {
            return base.Move();
        }

        public override string Eat(string food)
        {
            return base.Eat(food);
        }

        public virtual string Attack()
        {
            return $"{Name} used {Weapon.Name} to attack ";
        }
    }
}
