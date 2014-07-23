namespace StrategyPattern
{
    using System;

    public class MachineGun : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Taa taa taa taaaaaa taaaaaa!");
        }
    }
}
