namespace TryToKillACat
{
    using Mammals;
    using System;
    using System.Linq;

    class TestMammals
    {
        static void Main(string[] args)
        {
            Dog doggy = new Dog("peshko", 3, 80);
            Cat pissy = new Cat("peshka", 3);

            bool isDogDead = doggy.IsDead();
            bool isCatDead = pissy.IsDead();

            while (!isCatDead && !isDogDead)
            {
                ShowVitals(doggy, pissy);
                
                pissy.Scratch(doggy);
                isDogDead = doggy.IsDead();
                if (isDogDead)
                {
                    Console.WriteLine("Sorry {0}, but cats have 9 lives :)!", doggy.Name);
                    break;
                }

                doggy.Bite(pissy);
                isCatDead = pissy.IsDead();
                if (isCatDead)
                {
                    Console.WriteLine("Eventually {0} is stronger!", doggy.Name);
                    break;
                }
            }

        }

        private static void ShowVitals(Dog dog, Cat cat)
        {
            Console.WriteLine(dog);
            Console.WriteLine(cat);
        }
    }
}
