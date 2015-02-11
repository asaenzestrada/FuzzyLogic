using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inference
{
    public class InferenceBase
    {
        public double muCold, muWarm, muHot;

        public double rpmSlow, rpmMid, rpmFast;

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
    }
}
