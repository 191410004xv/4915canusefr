using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.lab3
{
    public partial class Formlab3b : Form
    {
        public Formlab3b()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_Amount.Text, out double x)==true && double.TryParse(txt_IR.Text,out double y)==true)
            {
               
                double v = x*Math.Pow((1+y/100),10);
                lbl_10years.Text = v.ToString("N0");
                int m = 0;
                for(int i = 0; x *Math.Pow((1 + y / 100), i) < 1000000; i++)
                {
                    m = i;
                }
                lblMillion2.Text = m.ToString("N0");
            }
            else
            {
                MessageBox.Show($"Invalid value");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblValue2_Click(object sender, EventArgs e)
        {

        }

        private void lblMillion2_Click(object sender, EventArgs e)
        {

        }
    }
}
