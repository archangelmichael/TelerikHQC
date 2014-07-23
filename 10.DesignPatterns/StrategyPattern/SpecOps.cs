namespace StrategyPattern
{
    using System;

    class SpecOps : Soldier
    {
        public SpecOps(string name) : base(name, new Bazooka()) { }
    }
}
