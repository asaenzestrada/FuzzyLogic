using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inference
{
    public class InferenceBase
    {
        public double muCold, muWarm, muHot, rpmSlow, rpmMid, rpmFast, 
                        limitCa, limitCb, limitWa, limitWb, limitHa, limitHb, 
                        result, 
                        aClause, bClause, cClause;

        public InferenceBase(double muC, double muW, double muH)
        {
            this.muCold = muC;
            this.muWarm = muW;
            this.muHot = muH;

            shootRules();
        }

        public void shootRules()
        {
            if (muCold > 0)
            {
                rpmSlow = muCold;
            }

            if (muWarm > 0)
            {
                rpmMid = muWarm;
            }

            if (muHot > 0)
            {
                rpmFast = muHot;
            }
        }

        public void defuzzyfication()
        {
            aClause = (muCold * limitCa) + (muCold * limitCb);
            bClause = (muWarm * limitWa) + (muWarm * limitWb);
            cClause = (muHot * limitHa) + (muHot * limitHb);

            result = (aClause + bClause + cClause) / 2*(muCold + muWarm + muHot);
        }
    }
}
