namespace Mammals
{
    using System;
    using System.Linq;

    public class Dog : Mammal
    {
        private const int DogMaxLife = 100;
        private int lifeForce;

        public Dog(string name, int age)
            : base(name, age)
        {
            this.LifeForce = DogMaxLife;
        }

        public Dog(string name, int age, int lifeForce)
            : base(name, age)
        {
            this.LifeForce = lifeForce;
        }

        public int LifeForce
        {
            get { return this.lifeForce; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(this.GetType().Name + " " + this.Name + " is dead!");
                }

                if (value > DogMaxLife)
                {
                    this.lifeForce = DogMaxLife;
                }
                else
                {
                    this.lifeForce = value;
                }

            }
        }

        public void Bite(Cat cat)
        {
            Console.WriteLine("{0} killed {1} {2}", this.Name, cat.GetType().Name, cat.Name);
            cat.Lives--;
        }

        public override bool IsDead()
        {
            return this.LifeForce <= 0;
        }

        public override string ToString()
        {
            return base.ToString() + " and has " + this.LifeForce + " life left!";
        }
    }
}
