using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FuzzyBase
{
    public class TrapezoidalMembership:MembershipBase
    {
        protected MethodInfo method; 
        public TrapezoidalMembership(double input, double a, double b, double c, double d)
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
            this.membershipGrade = 1;
        }

        public override void evaluateMembership()
        {
            if ((this.input <= this.aVert && aVert != 0) && this.input >= this.dVert) // if is out of the function's range it has no membership.
            {
                this.membershipGrade = 0;
                return;
            }

            if ((this.input >= this.cVert && input <= this.dVert) && this.membershipGrade == 0)
            {
                greaterCsmallerD();
            } 

            if ((this.input >= this.bVert && input <= this.cVert) && this.membershipGrade == 0)
            {
                greaterBsmallerC();
            }

            if ((this.input >= this.aVert && input <= this.bVert) && this.membershipGrade == 0)
            {
                greaterAsmallerB();
            }
        }

    }
}
