using System;
using System.Security.Policy;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCryptoApp
{
    public partial class SettingsForm : Form
    {
        private Form1 _mainForm;

        public SettingsForm(int apiRequestsTotal, Crypto crypto, Form1 mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            uriTextBox.Text = crypto.GetURI();
            apiRateUsedTextBox.Text = apiRequestsTotal.ToString();
        }

        private void apiDocsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string apiURL = "https://www.coingecko.com/api/documentation";


            // Create a new ProcessStartInfo enabled shell execute to open the URL .Net Core recommendation from Microsoft Documentation
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = apiURL
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open URL: {ex.Message}");
            }

        }

        public int Interval
        {
            get { return (int)numericUpDown1.Value; }
        }

        private void uriTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            int newInterval = (int)numericUpDown1.Value * 60000;
            _mainForm.SetRefreshDelay(newInterval);
            this.Close();
        }

    }

}
