using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal number1 = decimal.Parse(textBox1.Text);
                decimal number2 = decimal.Parse(textBox2.Text);

                decimal sum = number1 + number2;

                textBoxSum.Text = sum.ToString();
            }
            catch (Exception)
            {
                textBoxSum.Text = "error";
            }
        }
    }
}
