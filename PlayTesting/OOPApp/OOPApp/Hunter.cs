using System;
using System.Collections.Generic;
using System.Linq;
using OOPApp.Interfaces;

namespace OOPApp
{
    public class Hunter : Human // Sub Class of a Sub Class
    {
        

        public Hunter(string name, IAttackable weapon) : base(name, weapon)
        {
            
        }

        public override string Attack()
        {
            return base.Attack();
        }
    }
}
