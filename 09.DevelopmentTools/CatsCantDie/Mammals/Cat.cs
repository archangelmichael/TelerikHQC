namespace Mammals
{
    using System;
    using System.Linq;

    public class Cat :  Mammal
    {
        private const int CatMaxLives = 9;
        private const int CatScratchForce = 10;
        private int lives;

        public Cat(string name, int age)
            : base(name, age)
        {
            this.Lives = CatMaxLives;
        }

        public Cat(string name, int age, int lives)
            : base(name, age)
        {
            this.Lives = lives;
        }

        public int Lives
        {
            get { return this.lives; }
            set 
            { 
                if(value < 0) 
                {
                    throw new ArgumentOutOfRangeException(this.GetType().Name + " " + this.Name + " is dead!");
                }

                if (value > 9 )
                {
                    this.lives = CatMaxLives;
                }
                else
                {
                    this.lives = value;
                }
            }
        }

        public void Scratch(Dog dog)
        {
            Console.WriteLine(this.Name + " scratched " + dog.GetType().Name + " " + dog.Name);
            dog.LifeForce -= CatScratchForce;
        }

        public override bool IsDead()
        {
            return this.Lives <= 0;
        }

        public override string ToString()
        {
            return base.ToString() + " and has " + this.Lives + " lives left!"; ;
        }
    }
}
