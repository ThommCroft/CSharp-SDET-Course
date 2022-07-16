using OOPApp.Interfaces;

namespace OOPApp.Weapons
{
    public class BaseWeapon : IAttackable
    {
        private string _name = "";

        public string Name { get { return _name; } }

        string IAttackable.Name { get { return _name; } }

        public BaseWeapon()
        {

        }

        public BaseWeapon(string name)
        {
            _name = name;
        }

        public virtual string Attack()
        {
            return _name;
        }
    }
}
