using System;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCM_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtCM.Text, out double douCM))
            {
                txtM.Text = string.Format("{0:0.##########}", douCM / 100);
                txtKM.Text = string.Format("{0:0.##########}", douCM / 100000);
                txtIn.Text = string.Format("{0:0.##########}", douCM / 2.54);
                txtFt.Text = string.Format("{0:0.##########}", douCM / 30.48);
                txtYard.Text = string.Format("{0:0.##########}", douCM / 91.44);
            }
        }

        private void txtM_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtM.Text, out double douM))
            {
                txtCM.Text = string.Format("{0:0.##########}", douM * 100);
                txtKM.Text = string.Format("{0:0.##########}", douM / 1000);
                txtIn.Text = string.Format("{0:0.##########}", douM * 39.3701);
                txtFt.Text = string.Format("{0:0.##########}", douM * 3.28084);
                txtYard.Text = string.Format("{0:0.##########}", douM * 1.09361);
            }
        }

        private void txtKM_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtKM.Text, out double douKM))
            {
                txtCM.Text = string.Format("{0:0.##########}", douKM * 100000);
                txtM.Text = string.Format("{0:0.##########}", douKM * 1000);
                txtIn.Text = string.Format("{0:0.##########}", douKM * 39370.1);
                txtFt.Text = string.Format("{0:0.##########}", douKM * 3280.84);
                txtYard.Text = string.Format("{0:0.##########}", douKM * 1093.61);
            }
        }

        private void txtIn_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtIn.Text, out double douIn))
            {
                txtCM.Text = string.Format("{0:0.##########}", douIn * 2.54);
                txtM.Text = string.Format("{0:0.##########}", douIn / 39.3701);
                txtKM.Text = string.Format("{0:0.##########}", douIn / 39370.1);
                txtFt.Text = string.Format("{0:0.##########}", douIn / 12);
                txtYard.Text = string.Format("{0:0.##########}", douIn / 36);
            }
        }

        private void txtFt_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtFt.Text, out double douFt))
            {
                txtCM.Text = string.Format("{0:0.##########}", douFt * 30.48);
                txtM.Text = string.Format("{0:0.##########}", douFt / 3.28084);
                txtKM.Text = string.Format("{0:0.##########}", douFt / 3280.84);
                txtIn.Text = string.Format("{0:0.##########}", douFt * 12);
                txtYard.Text = string.Format("{0:0.##########}", douFt / 3);
            }
        }

        private void txtYd_KeyUp(object sender, KeyEventArgs e)
        {
            if (double.TryParse(txtYard.Text, out double douYd))
            {
                txtCM.Text = string.Format("{0:0.##########}", douYd * 91.44);
                txtM.Text = string.Format("{0:0.##########}", douYd / 1.09361);
                txtKM.Text = string.Format("{0:0.##########}", douYd / 1093.61);
                txtIn.Text = string.Format("{0:0.##########}", douYd * 36);
                txtFt.Text = string.Format("{0:0.##########}", douYd * 3);
            }
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = string.Empty;
            txtM.Text = string.Empty;
            txtKM.Text = string.Empty;
            txtIn.Text = string.Empty;
            txtFt.Text = string.Empty;
            txtYard.Text = string.Empty;
        }
    }
}
