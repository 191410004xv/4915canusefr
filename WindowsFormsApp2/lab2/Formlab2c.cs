using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.lab2
{
    public partial class Formlab2c : Form
    {
        public Formlab2c()
        {
            InitializeComponent();
        }

        private void Formlab2c_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Add($"{txtName.Text}");
            lblMessage.Text="The following item is selected: "+ $"{txtName.Text}";
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {

        }

        private void lstStudents_DoubleClick(object sender, EventArgs e)
        {
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lstStudents_Click(object sender, EventArgs e)
        {
           lblMessage.Text= "The following item is selected: " + lstStudents.SelectedItem.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
