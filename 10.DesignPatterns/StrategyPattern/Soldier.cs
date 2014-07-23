namespace StrategyPattern
{
    using System;

    public class Soldier
    {
        readonly IWeapon weapon;

        public Soldier(string name, IWeapon weapon)
        {
            this.Name = name;
            this.weapon = weapon;
        }

        public string Name {get; set;}

        public void Attack()
        {
            Console.WriteLine("{0} {1}", this.GetType().Name, this.Name);
            weapon.UseWeapon();
        }
    }
}
