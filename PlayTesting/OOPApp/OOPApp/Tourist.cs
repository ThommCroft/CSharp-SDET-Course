using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Tourist : Human
    {
        public Tourist(string name, string animalType = "Human") : base(name, animalType)
        {

        }
    }
}
