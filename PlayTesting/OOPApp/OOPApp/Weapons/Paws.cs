namespace OOPApp.Weapons
{
    public class Paws : BaseWeapon
    {
        public Paws(string name) : base(name)
        {

        }

        public override string Attack()
        {
            return $"{base.Attack()}";
        }
    }
}
