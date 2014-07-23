namespace StrategyPattern
{
    using System;

    public class Grenade : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Fire in the hole! BOOM!");
        }
    }
}
