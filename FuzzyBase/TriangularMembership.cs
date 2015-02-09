using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyBase
{
    public class TriangularMembership : MembershipBase
    {

        public TriangularMembership(double a, double b, double c)
        {
            this.aVert = a;
            this.bVert = b;
            this.cVert = c;
        }

        public override void evaluateMembership()
        {
            this.membershipGrade= 1.000;
        }


    }

    
}