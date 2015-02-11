using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Inference
{
    public class ITrapezoidalMembership:IMembershipBase
    {
        protected MethodInfo method; 
        public ITrapezoidalMembership(double input, double a, double b, double c, double d)
        {
            this.input = input;
            this.aVert = a;
            this.bVert = b;
            this.cVert = c;
            this.dVert = d;

            evaluateMembership();
        }

        public override void greaterBsmallerC()
        {
            this.rpm = 1;
        }

        public override void evaluateMembership()
        {
            if ((this.input <= this.aVert && aVert != 0) && this.input >= this.dVert) // if is out of the function's range it has no membership.
            {
                this.rpm = 0;
                return;
            }

            if ((this.input >= this.cVert && input <= this.dVert) && this.rpm == 0)
            {
                greaterCsmallerD();
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
