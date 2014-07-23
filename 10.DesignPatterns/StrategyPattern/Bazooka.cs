namespace StrategyPattern
{
    using System;

    public class Bazooka : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Incomming ...! KABOOM!");
        }
    }
}
