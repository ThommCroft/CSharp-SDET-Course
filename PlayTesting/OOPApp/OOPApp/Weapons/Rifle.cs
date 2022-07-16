namespace OOPApp.Weapons
{
    public class Rifle : BaseWeapon
    {
        public Rifle(string name) : base(name)
        {

        }

        public override string Attack()
        {
            return $"{base.Attack()}";
        }
    }
}
