using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyBase
{
    public class TriangularMembership : MembershipBase
    {

        public TriangularMembership(double input, double a, double b, double c)
        {
            this.input = input;
            this.aVert = a;
            this.bVert = b;
            this.cVert = c;

            evaluateMembership();
        }

        public override void greaterBsmallerC()
        {
            this.membershipGrade = (this.cVert - this.input) / (this.cVert - this.bVert);
        }

        public override void evaluateMembership()
        {
            if ((this.input <= this.aVert && aVert != 0) || this.input >= this.cVert)
            {
                this.membershipGrade = 0;
                return;
            }

            if (this.input >= this.bVert || input <= this.cVert && this.membershipGrade == 0)
            {
                greaterBsmallerC();
            }

            if (this.input >= this.aVert || input <= this.bVert && this.membershipGrade == 0)
            {
                greaterAsmallerB();
            }
        }


    }

    
}