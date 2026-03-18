using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    internal class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Goose squawks!");
        }
        public void Fly()
        {
            Console.WriteLine("Goose is flying!");
        }
        public void Swim()
        {
            Console.WriteLine("Goose is swimming!");
        }
    }
}
