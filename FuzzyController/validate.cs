using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyController
{
    static class validate
    {
        public static void validateTxt(System.Windows.Forms.TextBox myTxt)
        {

            double txtVal;

            //Check if the value is a valid number (float)
            bool isNum = Double.TryParse(myTxt.Text, out txtVal);

            //If is valid get the value
            if (isNum) { 
                txtVal = double.Parse(myTxt.Text);
            }

            //If the value is smaller than 0 the value will be changed to 0
            if (txtVal < 0 | !isNum)
            {
                myTxt.Text = "0";
                //System.Windows.Forms.MessageBox.Show("Hay valores incorrectos");
                myTxt.Focus();
            }
        }
    }
}
