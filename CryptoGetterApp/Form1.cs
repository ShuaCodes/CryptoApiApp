using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCryptoApp
{
    public partial class Form1 : Form
    {
        private Crypto crypto = new Crypto();

        private List<string> selectedCoinNames = new List<string>();
        private List<string> selectedCurrencyNames = new List<string>();

        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.Timer cooldownTimer;

        private List<CryptoPanel> cryptoPanels = new List<CryptoPanel>();

        private int apiRequestsInMinute = 0;
        private int apiRequestsTotal = 0;

        public int refreshDelay = 60000; //initialize refresh delay to 1 minute

        //Form1 Constructor
        public Form1()
        {
            InitializeComponent();

            // Initialize panels
            cryptoPanels.Add(new CryptoPanel(coinSelectBox1, currencySelectBox1, coinLivePrice1, historicalPriceListView1, pairDisplayPanel1));
            cryptoPanels.Add(new CryptoPanel(coinSelectBox2, currencySelectBox2, coinLivePrice2, historicalPriceListView2, pairDisplayPanel2));
            cryptoPanels.Add(new CryptoPanel(coinSelectBox3, currencySelectBox3, coinLivePrice3, historicalPriceListView3, pairDisplayPanel3));
            cryptoPanels.Add(new CryptoPanel(coinSelectBox4, currencySelectBox4, coinLivePrice4, historicalPriceListView4, pairDisplayPanel4));
            cryptoPanels.Add(new CryptoPanel(coinSelectBox5, currencySelectBox5, coinLivePrice5, historicalPriceListView5, pairDisplayPanel5));
            cryptoPanels.Add(new CryptoPanel(coinSelectBox6, currencySelectBox6, coinLivePrice6, historicalPriceListView6, pairDisplayPanel6));

            // Initialize coinSelectBoxes so that they contain different coins on intial load
            coinSelectBox1.SelectedIndex = 0;
            coinSelectBox2.SelectedIndex = 1;
            coinSelectBox3.SelectedIndex = 2;
            coinSelectBox4.SelectedIndex = 3;
            coinSelectBox5.SelectedIndex = 4;
            coinSelectBox6.SelectedIndex = 5;

            // Initialize and configure the Timer
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = refreshDelay; // 1 minute interval
            refreshTimer.Tick += new EventHandler(UpdateUIWithAPI);
            refreshTimer.Start();

            // Initialize the cooldown Timer
            cooldownTimer = new System.Windows.Forms.Timer();
            cooldownTimer.Interval = 60000; // 1 minute interval
            cooldownTimer.Tick += new EventHandler(ResetApiRequestsCount);
            cooldownTimer.Start();

            // Initialize panel select combobox
            panelNumberComboBox.SelectedIndex = 0;

            //Update the UI on initial form load, timer takes care of the rest
            this.Load += new EventHandler(Form1_Load); //using an event handler allows form1 to have prices on first load
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Now call UpdateUIWithAPI
            UpdateUIWithAPI(null, null);
        }

        // Method to update the UI with API data
        private async void UpdateUIWithAPI(object sender, EventArgs e)
        {
            try
            {
                if (apiRequestsInMinute >= 10) // Defines total rate limit
                {
                    MessageBox.Show("API rate limit reached. Please wait for cooldown.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cooldownTimer.Start();
                    return;
                }

                foreach (var panel in cryptoPanels)
                {
                    if (panel.DisplayPanel.Visible)
                    {
                        string selectedCoinName = panel.CoinSelectBox.SelectedItem.ToString().ToLower();
                        string selectedCurrencyName = panel.CurrencySelectBox.SelectedItem.ToString().ToLower();

                        double price = await crypto.GetCryptoPricesAsync(selectedCoinName, selectedCurrencyName);
                        if (price == 0)
                        {
                            MessageBox.Show("ERROR: API did not return a positive value\nCheck URI path in settings or troubleshoot your used rate limit");
                            continue;
                        }

                        // Update the price label for the panel
                        panel.PriceLabel.Text = price.ToString();

                        // Update the historical price list view for the panel
                        string timestamp = DateTime.Now.ToString("hh:mm:ss tt"); // 12 hour clock
                        ListViewItem listViewItem = new ListViewItem(timestamp);
                        listViewItem.SubItems.Add($"{selectedCoinName}_{selectedCurrencyName}"); // Pair
                        listViewItem.SubItems.Add(price.ToString()); // Price

                        panel.HistoricalPriceListView.Items.Insert(0, listViewItem);

                        // Increment the API requests count
                        apiRequestsInMinute++;
                        apiRequestsTotal++;
                        if (apiRateLimitProgressBar.Value <= 90) // Prevent overflow
                            apiRateLimitProgressBar.Value += 10;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to reset the API requests count after cooldown
        private void ResetApiRequestsCount(object sender, EventArgs e)
        {
            apiRequestsInMinute = 0;
            apiRateLimitProgressBar.Value = 0;
        }

        public void SetRefreshDelay(int milliseconds)
        {
            refreshDelay = milliseconds;
            refreshTimer.Interval = refreshDelay;
        }

        private void UpdatePanelVisibility(int numberOfPanelsToShow)
        {
            for (int i = 0; i < cryptoPanels.Count; i++)
            {
                cryptoPanels[i].DisplayPanel.Visible = i < numberOfPanelsToShow;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateUIWithAPI(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(apiRequestsTotal, crypto, this);
            settingsForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void panelNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelNumberComboBox.SelectedItem != null)
            {
                int numberOfPanelsToShow = int.Parse(panelNumberComboBox.SelectedItem.ToString());
                UpdatePanelVisibility(numberOfPanelsToShow);

                if (numberOfPanelsToShow == 1)
                {
                    this.Size = new Size(500, 630);
                    this.MinimumSize = new Size(500, 630);
                }
                else if (numberOfPanelsToShow == 2)
                {
                    this.Size = new Size(968, 630);
                    this.MinimumSize = new Size(968, 630);
                }
                else if (numberOfPanelsToShow == 3)
                {
                    this.Size = new Size(1448, 630);
                    this.MinimumSize = new Size(1448, 630);
                }
                else if (numberOfPanelsToShow >= 4)
                {
                    this.Size = new Size(1448, 1015);
                    this.MinimumSize = new Size(1448, 1015);
                }
            }
        }
    }
}
