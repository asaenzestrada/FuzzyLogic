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
            txtFrioA.Text = "0";
            txtFrioB.Text = "9";
            txtFrioC.Text = "15";

            txtTempladoA.Text = "12";
            txtTempladoB.Text = "18";
            txtTempladoC.Text = "22";
            txtTempladoD.Text = "27";

            txtCalienteA.Text = "24";
            txtCalienteB.Text = "30";
            txtCalienteC.Text = "35";

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
            
        }

    }
}
