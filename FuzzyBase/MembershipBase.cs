using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyBase
{
    public abstract class MembershipBase
    {
        public double input, xVert, aVert, bVert, cVert, dVert, membershipGrade, eval;

        public abstract void evaluateMembership();

        protected void greaterAsmallerB()
        {
            this.membershipGrade = (this.input - this.aVert) / (this.bVert - this.aVert);
        }

        public abstract void greaterBsmallerC();

        protected void greaterCsmallerD()
        {
            this.membershipGrade = (this.dVert - this.input) / (this.dVert - this.cVert);
        }
    }
}
