using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Snap! {ToString()}";
        }

        public override string ToString()
        {
            return _brand;
        }
    }
}
