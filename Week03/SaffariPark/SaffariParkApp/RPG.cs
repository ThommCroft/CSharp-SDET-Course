using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public class RPG : Weapon
    {
        public RPG(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {
            return $"Boom! {base.Shoot()}";
        }
    }
}
