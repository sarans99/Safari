using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    public abstract class Animal
    {
        public float Weight { get; set; }

        public Animal(float weight)
        {
            this.Weight = weight;
        }
        public abstract void MakeSound();
    }
}