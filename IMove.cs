using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari
{
    [Obsolete("IMove is deprecated. Please use IFly, IHunt or ISwim instead.", error: true)]
    interface IMove
    {
        public void Move();
    }
}