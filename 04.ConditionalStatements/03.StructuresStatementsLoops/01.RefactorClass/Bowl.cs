using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorClass
{
    class Bowl
    {
        private ICollection<Vegetable> itemsInBowl;

        public Bowl()
        {
            itemsInBowl = new List<Vegetable>();
        }

        public ICollection<Vegetable> ItemsInBowl
        {
            get { return this.itemsInBowl; }
        }

        public void Add(Vegetable product)
        {
            itemsInBowl.Add(product);
        }

        public override string ToString()
        {
            string listOfProducts = "";
            foreach (var product in ItemsInBowl)
            {
                listOfProducts += product + "; ";
            }
            return listOfProducts;
        }
    }
}
