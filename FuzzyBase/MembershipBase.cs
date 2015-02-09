using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyBase
{
    public abstract class MembershipBase
    {
        protected double xVert, aVert, bVert, cVert, dVert, membershipGrade;

        public abstract void evaluateMembership();
    
    }
}
