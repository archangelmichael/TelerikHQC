namespace StrategyPattern
{
    using System;

    public class Gunman : Soldier
    {
        public Gunman(string name) : base(name, new MachineGun()) { }
    }
}
