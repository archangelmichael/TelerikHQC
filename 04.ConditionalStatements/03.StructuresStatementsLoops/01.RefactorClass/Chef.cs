using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorClass
{
    public class Chef
    {
        private string chefName;

        public Chef(string name)
        {
            this.ChefName = name; 
        }

        public string ChefName
        {
            get { return this.chefName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Chef must have a name");
                }
                this.chefName = value;
            }
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl;
            Peel(potato);
            Peel(carrot);
            bowl = GetBowl();
            Cut(potato);
            Cut(carrot);
            bowl.Add(carrot);
            bowl.Add(potato);
            Console.WriteLine(this.ChefName + " cooked " + bowl);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable product)
        {
            product.Weight = product.Weight - 10;
        }

        private void Cut(Vegetable product)
        {
            product.IsCutToPieces = true;
        }
    }
}
