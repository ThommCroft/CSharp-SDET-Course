using System;
using System.Collections.Generic;
using System.Linq;

namespace SaffariParkApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }

        public Hunter()
        {
            
        }

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            return $"{FullName} used {Shooter}";
        }

        public override sealed string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter}";
        }
    }
}
