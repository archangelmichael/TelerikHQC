namespace Mammals
{
    using System;
    using System.Linq;

    public abstract class Mammal
    {
        private string name;
        private int age;

        protected Mammal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.name = "The Animal With No Name!";
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (0 > value || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Animal is not alive!");
                }

                this.age = value;
            }
        }

        public abstract bool IsDead();

        public override string ToString()
        {
            return this.GetType().Name + " named: " + this.Name + " is " + this.Age + " years old";
        }
    }
}
