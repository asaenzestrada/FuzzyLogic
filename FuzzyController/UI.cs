using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyBase;

namespace FuzzyController
{
    public partial class UI : Form
    {

        public UI()
        {
            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            this.loadDefaultValues();
        }

        protected void loadDefaultValues()
        {
            txtInputTemp.Text = "27";
            
            /*Set temperature values*/
            txtFrioA.Text = "0.1";
            txtFrioB.Text = "5";
            txtFrioC.Text = "11";

            txtTempladoA.Text = "9";
            txtTempladoB.Text = "18";
            txtTempladoC.Text = "25";

            txtCalienteA.Text = "18";
            txtCalienteB.Text = "27";
            txtCalienteC.Text = "35";
            txtCalienteD.Text = "40";

            /*Set speed values*/
            txtLentoA.Text = "300";
            txtLentoB.Text = "600";
            txtLentoC.Text = "900";

            txtMedioA.Text = "500";
            txtMedioB.Text = "800";
            txtMedioC.Text = "1200";
            txtMedioD.Text = "1500";

            txtRapidoA.Text = "1400";
            txtRapidoB.Text = "2000";
            txtRapidoC.Text = "2600";
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            this.loadDefaultValues();
        }

        protected void displayMsg(string text)
        {
            MessageBox.Show(text);
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            evaluateMe();
        }

        protected void evaluateMe()
        {
            double input;
            double.TryParse(txtInputTemp.Text, out input);

            //Cold membership
            double fa;
            double fb;
            double fc;

            double.TryParse(txtFrioA.Text, out fa);
            double.TryParse(txtFrioB.Text, out fb);
            double.TryParse(txtFrioC.Text, out fc);

            TriangularMembership cold = new TriangularMembership(input, fa, fb, fc);


            //warm membership
            double ta;
            double tb;
            double tc;

            double.TryParse(txtTempladoA.Text, out ta);
            double.TryParse(txtTempladoB.Text, out tb);
            double.TryParse(txtTempladoC.Text, out tc);

            TriangularMembership warm = new TriangularMembership(input, ta, tb, tc);


            //Hot membership
            double wa;
            double wb;
            double wc;
            double wd;

            double.TryParse(txtCalienteA.Text, out wa);
            double.TryParse(txtCalienteB.Text, out wb);
            double.TryParse(txtCalienteC.Text, out wc);
            double.TryParse(txtCalienteD.Text, out wd);

            TrapezoidalMembership hot = new TrapezoidalMembership(input, wa, wb, wc, wd);


            //Display values breakdown
            textBox3.Text = cold.membershipGrade.ToString();
            textBox2.Text = warm.membershipGrade.ToString();
            textBox1.Text = hot.membershipGrade.ToString();
        }
    }
}
