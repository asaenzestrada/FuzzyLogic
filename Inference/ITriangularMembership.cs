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

            evaluateMembership();
        }

        public override void greaterBsmallerC()
        {
            this.rpm = cVert - (input * (cVert - bVert));
        }

        public override void evaluateMembership()
        {
            if ((this.input <= this.aVert && aVert != 0) && this.input >= this.cVert)
            {
                this.rpm = 0;
                return;
            }

            if ((this.input >= this.bVert && input <= this.cVert) && this.rpm == 0)
            {
                greaterBsmallerC();
            }

            if ((this.input >= this.aVert && input <= this.bVert) && this.rpm == 0)
            {
                greaterAsmallerB();
            }
        }


    }

    
}