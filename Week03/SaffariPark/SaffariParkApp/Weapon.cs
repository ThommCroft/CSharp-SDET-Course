using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"{ToString()}";
        }

        public override string ToString()
        {
            return _brand;
        }
    }
}
