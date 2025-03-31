using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp2.lab4
{
    public partial class frmLab4 : Form
    {
        public frmLab4()
        {
            InitializeComponent();
        }

        private void frmLab4_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private async Task<string> GetApiResponse()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);
                    HttpResponseMessage response = await client.GetAsync("/api/Values/SimpleGetMethod");

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        MessageBox.Show(error);
                        return error;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show($"Request error: {e.Message}");
                return $"Request error: {e.Message}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return $"An error occurred: {ex.Message}";
            }
        }





        private async void btn_Click(object sender, EventArgs e)
        {
            string response = await GetApiResponse();
            lblResult.Text = response;
        }

       
    }
}
