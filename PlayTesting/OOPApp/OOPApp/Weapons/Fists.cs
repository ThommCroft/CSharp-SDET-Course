namespace OOPApp.Weapons
{
    public class Fists : BaseWeapon
    {
        public Fists(string name) : base(name)
        {

        }

        public override string Attack()
        {
            return $"{base.Attack()}";
        }
    }
}
