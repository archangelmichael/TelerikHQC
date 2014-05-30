using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RefactorClass
{
    class Vegetable
    {
        private const double INITIAL_WEIGHT = 100;
        private double weight;
        private bool isCutToPieces;

        public Vegetable()
        {
            this.Weight = INITIAL_WEIGHT;
            this.IsCutToPieces = false;
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No product left!");
                }
                this.weight = value;
            }
        }

        public bool IsCutToPieces
        {
            get { return this.isCutToPieces; }
            set { this.isCutToPieces = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} grams of {1}  Cut in pieces: {2}",this.Weight,this.GetType().Name,this.IsCutToPieces);
        }
    }
}
