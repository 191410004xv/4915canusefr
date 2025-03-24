
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2.lab2
{
    public partial class Formlab2a : Form
    {

        private int price =0;
        private string payment;
        public Formlab2a()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbnresult_Click(object sender, EventArgs e)
        {

        }

        private void redwine_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }
        

        private void whitewine_CheckedChanged_1(object sender, EventArgs e)
        {
            price = 180;
        }

        private void beer_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void visa_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void mastercard_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(payment)){
                try
                {
                    int total = Convert.ToInt32(qty.Text) * price;
                    lbnresult.Text = "Total :" + total + ", Payment: " + payment;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("please input correct numbers");
                }
            }
            else
            {
                MessageBox.Show("please chose visa or master");
            }
                
           
            
        }
    }
}


