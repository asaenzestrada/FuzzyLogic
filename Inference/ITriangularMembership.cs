using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inference
{
    public class ITriangularMembership : IMembershipBase
    {

        public ITriangularMembership(double input, double a, double b, double c)
        {
            this.input = input;
            this.aVert = a;
            this.bVert = b;
            this.cVert = c;

            evaluate();
        }

        public override void evaluate()
        {
            za = (input * (bVert - aVert)) + aVert;
            zb = cVert - (input * (cVert - bVert));
        }
    }
}