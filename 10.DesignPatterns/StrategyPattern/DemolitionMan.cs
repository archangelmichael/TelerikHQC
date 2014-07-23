namespace StrategyPattern
{
    using System;

    public class DemolitionMan : Soldier
    {
        public DemolitionMan(string name) : base(name, new Grenade()) { }
    }
}
