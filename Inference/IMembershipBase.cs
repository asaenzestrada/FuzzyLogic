using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inference
{
    public abstract class IMembershipBase
    {
        public double input, xVert, aVert, bVert, cVert, dVert, rpm, za, zb;

        public abstract void evaluate();

    }
}
