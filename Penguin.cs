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
            throw new NotImplementedException();
        }

        public void Move()
        {
            Console.WriteLine("Penguin is moving!");
        }
    }
}
