using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    internal class Water : SafariEnvironment<ISwim>
    {
        public override void CheckAnimalsInEnvironment()
        {
            foreach (Animal animal in animalsInEnvironment)
            {
                if (animal is ISwim swimmingAnimal)
                {
                    swimmingAnimal.Swim();
                }
            }
        }
    }
}
