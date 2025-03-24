using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class lab2b : Form
    {
        string weather;
        public lab2b()
        {
            InitializeComponent();
        }

        

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void cloudy_CheckedChanged(object sender, EventArgs e)
        {
            pic_cloudy.Visible = true;
            pic_snow.Visible = false;
            pic_sunny.Visible = false;
            pic_rainy.Visible = false;
            weather = "cloudy";
            chat(weather);

        }

        private void rainy_CheckedChanged(object sender, EventArgs e)
        {
            pic_cloudy.Visible = false;
            pic_snow.Visible = false;
            pic_sunny.Visible = false;
            pic_rainy.Visible = true;
            weather = "rainy";
            chat(weather);
        }

        private void sunny_CheckedChanged(object sender, EventArgs e)
        {
            pic_cloudy.Visible = false;
            pic_snow.Visible = false;
            pic_sunny.Visible = true;
            pic_rainy.Visible = false;
            weather = "sunny";
            chat(weather);
        }

        private void snowy_CheckedChanged(object sender, EventArgs e)
        {
            pic_cloudy.Visible =false;
            pic_snow.Visible = true;
            pic_sunny.Visible = false;
            pic_rainy.Visible = false;
            weather = "snowy";
            chat(weather);
        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pic_snow_Click(object sender, EventArgs e)
        {

        }

        private void pic_rainy_Click(object sender, EventArgs e)
        {

        }

        private void chat(string weather)
        {
            if (weather != null) {
                label_result.Text = "Is going to be a "+ weather+ " day today. "+ $"{txtname.Text}";   
            }

        }
    }
}
