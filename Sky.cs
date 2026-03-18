using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
        internal class Sky : SafariEnvironment<IFly>
        {
            public override void CheckAnimalsInEnvironment()
            {
                foreach (Animal animal in animalsInEnvironment)
                {
                    if (animal is IFly flyingAnimal)
                    {
                        flyingAnimal.Fly();
                    }
                }
            }
        }
}
