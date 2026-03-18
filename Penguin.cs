using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    internal class Penguin : Bird
    {
        public Penguin(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin squawks!");
        }

        public void Hunt()
        {
            Console.WriteLine("Penguin is hunting in the water!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }
    }
}
