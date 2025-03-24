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
    public partial class Formlab3a : Form
    {
        public Formlab3a()
        {
            InitializeComponent();
        }

        private void lblCast_Click(object sender, EventArgs e)
        {
            

            
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"you vote for \n{cboMovie.SelectedItem.ToString()}");
            }
            else if (dialogResult == DialogResult.No)
            {

                MessageBox.Show($"Cancel vote!");
            }
        }
    }
}
