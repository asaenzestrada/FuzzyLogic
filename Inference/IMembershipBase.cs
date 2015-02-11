using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inference
{
    public abstract class IMembershipBase
    {
        public double input, xVert, aVert, bVert, cVert, dVert, rpm;

        public abstract void evaluateMembership();

        protected void greaterAsmallerB()
        {
            this.rpm = (input * (bVert - aVert)) + aVert;
        }

        public abstract void greaterBsmallerC();

        protected void greaterCsmallerD()
        {
            //this.membershipGrade = (this.dVert - this.input) / (this.dVert - this.cVert); // Not sure how to trasform
            this.rpm = dVert - (input * (dVert - cVert));
        }
    }
}
