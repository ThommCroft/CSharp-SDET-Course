using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Human : BaseAnimal // Sub Class
    {
        public Human(string name, string animalType) : base(name, animalType)
        {

        }

        public override string Move() // Polymorphism
        {
            return base.Move();
        }

        public override string Eat(string food)
        {
            return base.Eat(food);
        }

        public override string Attack()
        {
            return base.Attack();
        }
    }
}
