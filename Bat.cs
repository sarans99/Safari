using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    internal class Bat : Mammal, IHunt, IFly
    {
        public Bat(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bat squawks!");
        }
        public void Hunt()
        {
            Console.WriteLine("Bat is hunting in the air!");
        }
        public void Fly()
        {
            Console.WriteLine("Bat is flying!");
        }
    }
}
