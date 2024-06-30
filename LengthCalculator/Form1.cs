using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LengthCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertAndDisplay(double value, string unit)
        {
            var conversions = new Dictionary<string, double>
            {
                { "cm", 1 },
                { "m", 0.01 },
                { "km", 0.00001 },
                { "in", 1 / 2.54 },
                { "ft", 1 / 30.48 },
                { "yard", 1 / 91.44 }
            };

            foreach (var key in conversions.Keys)
            {
                TextBox textBox = Controls["txt" + key.Substring(0, 1).ToUpper() + key.Substring(1)] as TextBox;
                textBox.Text = string.Format("{0:0.##########}", value * conversions[key]);
            }
        }

        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (double.TryParse(textBox.Text, out double value))
            {
                string unit = textBox.Name.Substring(3).ToLower();
                ConvertAndDisplay(value * (unit == "cm" ? 1 : unit == "m" ? 100 : unit == "km" ? 100000 : unit == "in" ? 2.54 : unit == "ft" ? 30.48 : 91.44), "cm");
                txtInfo.Text = string.Empty; // 清除之前的錯誤消息
            }
            else
            {
                txtInfo.Text = "請輸入有效的數字";
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
