using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.lab2;
using WindowsFormsApp2.lab3;
using WindowsFormsApp2.lab1;

namespace WindowsFormsApp2
{
    public partial class Formmenu : Form
    {
        public Formmenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            switch (cboLabs.SelectedItem.ToString()) {

                case "Lab1":
                    Form1 formlab1 = new Form1();
                    formlab1.Show();
                    break;


                case "Lab2A":
                    Formlab2a formlab2A = new Formlab2a();
                    formlab2A.Show(); break;





                case "Lab2B":
                    lab2b formlab2B = new lab2b();  
                    formlab2B.Show();
                    break;

                case "Lab2C":
                    Formlab2c formlab2C = new Formlab2c();
                    formlab2C.Show();
                    break;

                case "Lab3a":
                    Formlab3a formlab3A = new Formlab3a();  
                    formlab3A.Show(); break;

                case "Lab3b":
                    Formlab3b formlab3B = new Formlab3b();
                    formlab3B.Show(); break;    
                




            }

        }

        private void Formmenu_Load(object sender, EventArgs e)
        {
            cboLabs.Items.Add("Lab1");
            cboLabs.Items.Add("Lab2A");
            cboLabs.Items.Add("Lab2B");
            cboLabs.Items.Add("Lab2C");
            cboLabs.Items.Add("Lab3a");
            cboLabs.Items.Add("Lab3b");
        }
    }
}
