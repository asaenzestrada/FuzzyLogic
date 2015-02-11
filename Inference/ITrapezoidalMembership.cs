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
        
        }

        public override void evaluate()
        {
            throw new NotImplementedException();
        }
    }
}
