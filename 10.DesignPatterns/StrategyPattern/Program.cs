namespace StrategyPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Gunman gunner = new Gunman("Pesho");
            SpecOps bazi = new SpecOps("Vasko");
            DemolitionMan demolisher = new DemolitionMan("Gosho");

            bazi.Attack();
            demolisher.Attack();
            gunner.Attack();
        }
    }
}
