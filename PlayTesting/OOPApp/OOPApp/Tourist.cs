using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Tourist : Human
    {
        public Tourist(string name, IAttackable weapon) : base(name, weapon)
        {

        }
    }
}
