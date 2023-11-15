namespace MyCryptoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            updateButton = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            panelNumberComboBox = new ToolStripComboBox();
            pairDisplayPanel1 = new Panel();
            label1 = new Label();
            currencySelectBox1 = new ComboBox();
            coinSelectBox1 = new ComboBox();
            historicalPriceListView1 = new ListView();
            Timestamp = new ColumnHeader();
            Pair = new ColumnHeader();
            Price = new ColumnHeader();
            coinLivePrice1 = new Label();
            coinPriceLabel1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            apiRateLimitProgressBar = new ToolStripProgressBar();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pairDisplayPanel2 = new Panel();
            label2 = new Label();
            currencySelectBox2 = new ComboBox();
            coinSelectBox2 = new ComboBox();
            historicalPriceListView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            coinLivePrice2 = new Label();
            coinPriceLabel2 = new Label();
            pairDisplayPanel3 = new Panel();
            label3 = new Label();
            currencySelectBox3 = new ComboBox();
            coinSelectBox3 = new ComboBox();
            historicalPriceListView3 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            coinLivePrice3 = new Label();
            coinPriceLabel3 = new Label();
            pairDisplayPanel4 = new Panel();
            label6 = new Label();
            currencySelectBox4 = new ComboBox();
            coinSelectBox4 = new ComboBox();
            historicalPriceListView4 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            coinLivePrice4 = new Label();
            coinPriceLabel4 = new Label();
            pairDisplayPanel5 = new Panel();
            label9 = new Label();
            currencySelectBox5 = new ComboBox();
            coinSelectBox5 = new ComboBox();
            historicalPriceListView5 = new ListView();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            coinLivePrice5 = new Label();
            coinPriceLabel5 = new Label();
            pairDisplayPanel6 = new Panel();
            label12 = new Label();
            currencySelectBox6 = new ComboBox();
            coinSelectBox6 = new ComboBox();
            historicalPriceListView6 = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            coinLivePrice6 = new Label();
            coinPriceLabel6 = new Label();
            menuStrip1.SuspendLayout();
            pairDisplayPanel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            pairDisplayPanel2.SuspendLayout();
            pairDisplayPanel3.SuspendLayout();
            pairDisplayPanel4.SuspendLayout();
            pairDisplayPanel5.SuspendLayout();
            pairDisplayPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // updateButton
            // 
            updateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            updateButton.Location = new Point(44, 424);
            updateButton.Margin = new Padding(5);
            updateButton.MaximumSize = new Size(382, 88);
            updateButton.MinimumSize = new Size(382, 88);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(382, 88);
            updateButton.TabIndex = 0;
            updateButton.Text = "Update Prices ";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, toolStripTextBox1, panelNumberComboBox });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(474, 46);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 40);
            fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(233, 44);
            settingsToolStripMenuItem.Text = "&Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(233, 44);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(84, 40);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(212, 44);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(150, 40);
            toolStripTextBox1.Text = "Total Panels = ";
            // 
            // panelNumberComboBox
            // 
            panelNumberComboBox.DropDownWidth = 60;
            panelNumberComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            panelNumberComboBox.Name = "panelNumberComboBox";
            panelNumberComboBox.Size = new Size(121, 40);
            panelNumberComboBox.SelectedIndexChanged += panelNumberComboBox_SelectedIndexChanged;
            // 
            // pairDisplayPanel1
            // 
            pairDisplayPanel1.BackColor = SystemColors.ActiveCaption;
            pairDisplayPanel1.Controls.Add(label1);
            pairDisplayPanel1.Controls.Add(currencySelectBox1);
            pairDisplayPanel1.Controls.Add(coinSelectBox1);
            pairDisplayPanel1.Controls.Add(historicalPriceListView1);
            pairDisplayPanel1.Controls.Add(coinLivePrice1);
            pairDisplayPanel1.Controls.Add(coinPriceLabel1);
            pairDisplayPanel1.Location = new Point(14, 47);
            pairDisplayPanel1.Margin = new Padding(5);
            pairDisplayPanel1.Name = "pairDisplayPanel1";
            pairDisplayPanel1.Size = new Size(445, 362);
            pairDisplayPanel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 125);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 6;
            label1.Text = "Price History";
            // 
            // currencySelectBox1
            // 
            currencySelectBox1.FormattingEnabled = true;
            currencySelectBox1.Location = new Point(237, 3);
            currencySelectBox1.Name = "currencySelectBox1";
            currencySelectBox1.Size = new Size(204, 58);
            currencySelectBox1.TabIndex = 5;
            // 
            // coinSelectBox1
            // 
            coinSelectBox1.BackColor = SystemColors.Window;
            coinSelectBox1.FormattingEnabled = true;
            coinSelectBox1.Location = new Point(3, 3);
            coinSelectBox1.Name = "coinSelectBox1";
            coinSelectBox1.Size = new Size(196, 58);
            coinSelectBox1.TabIndex = 4;
            // 
            // historicalPriceListView1
            // 
            historicalPriceListView1.BackColor = SystemColors.ControlLight;
            historicalPriceListView1.Columns.AddRange(new ColumnHeader[] { Timestamp, Pair, Price });
            historicalPriceListView1.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            historicalPriceListView1.Location = new Point(3, 165);
            historicalPriceListView1.Name = "historicalPriceListView1";
            historicalPriceListView1.Size = new Size(438, 194);
            historicalPriceListView1.TabIndex = 3;
            historicalPriceListView1.UseCompatibleStateImageBehavior = false;
            historicalPriceListView1.View = View.Details;
            // 
            // Timestamp
            // 
            Timestamp.Text = "Timestamp";
            Timestamp.Width = 165;
            // 
            // Pair
            // 
            Pair.Text = "Pair";
            Pair.Width = 160;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 108;
            // 
            // coinLivePrice1
            // 
            coinLivePrice1.BackColor = Color.LimeGreen;
            coinLivePrice1.BorderStyle = BorderStyle.FixedSingle;
            coinLivePrice1.FlatStyle = FlatStyle.Flat;
            coinLivePrice1.Location = new Point(237, 64);
            coinLivePrice1.Name = "coinLivePrice1";
            coinLivePrice1.Size = new Size(204, 52);
            coinLivePrice1.TabIndex = 2;
            coinLivePrice1.Text = "...";
            // 
            // coinPriceLabel1
            // 
            coinPriceLabel1.AutoSize = true;
            coinPriceLabel1.BackColor = Color.LimeGreen;
            coinPriceLabel1.Font = new Font("Segoe UI", 13.875F, FontStyle.Underline, GraphicsUnit.Point);
            coinPriceLabel1.Location = new Point(7, 64);
            coinPriceLabel1.Name = "coinPriceLabel1";
            coinPriceLabel1.Size = new Size(192, 50);
            coinPriceLabel1.TabIndex = 1;
            coinPriceLabel1.Text = "Live Price: ";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, apiRateLimitProgressBar, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 517);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(474, 42);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(173, 32);
            toolStripStatusLabel1.Text = "API Rate Limit: ";
            // 
            // apiRateLimitProgressBar
            // 
            apiRateLimitProgressBar.Name = "apiRateLimitProgressBar";
            apiRateLimitProgressBar.Size = new Size(200, 30);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(525, 32);
            toolStripStatusLabel2.Text = "*Pricing Information Provided by CoinGecko API";
            // 
            // pairDisplayPanel2
            // 
            pairDisplayPanel2.BackColor = SystemColors.ActiveCaption;
            pairDisplayPanel2.Controls.Add(label2);
            pairDisplayPanel2.Controls.Add(currencySelectBox2);
            pairDisplayPanel2.Controls.Add(coinSelectBox2);
            pairDisplayPanel2.Controls.Add(historicalPriceListView2);
            pairDisplayPanel2.Controls.Add(coinLivePrice2);
            pairDisplayPanel2.Controls.Add(coinPriceLabel2);
            pairDisplayPanel2.Location = new Point(485, 47);
            pairDisplayPanel2.Margin = new Padding(5);
            pairDisplayPanel2.Name = "pairDisplayPanel2";
            pairDisplayPanel2.Size = new Size(445, 362);
            pairDisplayPanel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(144, 125);
            label2.Name = "label2";
            label2.Size = new Size(165, 37);
            label2.TabIndex = 6;
            label2.Text = "Price History";
            // 
            // currencySelectBox2
            // 
            currencySelectBox2.FormattingEnabled = true;
            currencySelectBox2.Location = new Point(237, 3);
            currencySelectBox2.Name = "currencySelectBox2";
            currencySelectBox2.Size = new Size(204, 58);
            currencySelectBox2.TabIndex = 5;
            // 
            // coinSelectBox2
            // 
            coinSelectBox2.BackColor = SystemColors.Window;
            coinSelectBox2.FormattingEnabled = true;
            coinSelectBox2.Location = new Point(3, 3);
            coinSelectBox2.Name = "coinSelectBox2";
            coinSelectBox2.Size = new Size(196, 58);
            coinSelectBox2.TabIndex = 4;
            // 
            // historicalPriceListView2
            // 
            historicalPriceListView2.BackColor = SystemColors.ControlLight;
            historicalPriceListView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            historicalPriceListView2.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            historicalPriceListView2.Location = new Point(3, 165);
            historicalPriceListView2.Name = "historicalPriceListView2";
            historicalPriceListView2.Size = new Size(438, 194);
            historicalPriceListView2.TabIndex = 3;
            historicalPriceListView2.UseCompatibleStateImageBehavior = false;
            historicalPriceListView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Timestamp";
            columnHeader1.Width = 165;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Pair";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Price";
            columnHeader3.Width = 108;
            // 
            // coinLivePrice2
            // 
            coinLivePrice2.BackColor = Color.LimeGreen;
            coinLivePrice2.BorderStyle = BorderStyle.FixedSingle;
            coinLivePrice2.FlatStyle = FlatStyle.Flat;
            coinLivePrice2.Location = new Point(237, 64);
            coinLivePrice2.Name = "coinLivePrice2";
            coinLivePrice2.Size = new Size(204, 52);
            coinLivePrice2.TabIndex = 2;
            coinLivePrice2.Text = "...";
            // 
            // coinPriceLabel2
            // 
            coinPriceLabel2.AutoSize = true;
            coinPriceLabel2.BackColor = Color.LimeGreen;
            coinPriceLabel2.Font = new Font("Segoe UI", 13.875F, FontStyle.Underline, GraphicsUnit.Point);
            coinPriceLabel2.Location = new Point(7, 64);
            coinPriceLabel2.Name = "coinPriceLabel2";
            coinPriceLabel2.Size = new Size(192, 50);
            coinPriceLabel2.TabIndex = 1;
            coinPriceLabel2.Text = "Live Price: ";
            // 
            // pairDisplayPanel3
            // 
            pairDisplayPanel3.BackColor = SystemColors.ActiveCaption;
            pairDisplayPanel3.Controls.Add(label3);
            pairDisplayPanel3.Controls.Add(currencySelectBox3);
            pairDisplayPanel3.Controls.Add(coinSelectBox3);
            pairDisplayPanel3.Controls.Add(historicalPriceListView3);
            pairDisplayPanel3.Controls.Add(coinLivePrice3);
            pairDisplayPanel3.Controls.Add(coinPriceLabel3);
            pairDisplayPanel3.Location = new Point(960, 47);
            pairDisplayPanel3.Margin = new Padding(5);
            pairDisplayPanel3.Name = "pairDisplayPanel3";
            pairDisplayPanel3.Size = new Size(445, 362);
            pairDisplayPanel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(144, 125);
            label3.Name = "label3";
            label3.Size = new Size(165, 37);
            label3.TabIndex = 6;
            label3.Text = "Price History";
            // 
            // currencySelectBox3
            // 
            currencySelectBox3.FormattingEnabled = true;
            currencySelectBox3.Location = new Point(237, 3);
            currencySelectBox3.Name = "currencySelectBox3";
            currencySelectBox3.Size = new Size(204, 58);
            currencySelectBox3.TabIndex = 5;
            // 
            // coinSelectBox3
            // 
            coinSelectBox3.BackColor = SystemColors.Window;
            coinSelectBox3.FormattingEnabled = true;
            coinSelectBox3.Location = new Point(3, 3);
            coinSelectBox3.Name = "coinSelectBox3";
            coinSelectBox3.Size = new Size(196, 58);
            coinSelectBox3.TabIndex = 4;
            // 
            // historicalPriceListView3
            // 
            historicalPriceListView3.BackColor = SystemColors.ControlLight;
            historicalPriceListView3.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5, columnHeader6 });
            historicalPriceListView3.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            historicalPriceListView3.Location = new Point(3, 165);
            historicalPriceListView3.Name = "historicalPriceListView3";
            historicalPriceListView3.Size = new Size(438, 194);
            historicalPriceListView3.TabIndex = 3;
            historicalPriceListView3.UseCompatibleStateImageBehavior = false;
            historicalPriceListView3.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Timestamp";
            columnHeader4.Width = 165;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Pair";
            columnHeader5.Width = 160;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Price";
            columnHeader6.Width = 108;
            // 
            // coinLivePrice3
            // 
            coinLivePrice3.BackColor = Color.LimeGreen;
            coinLivePrice3.BorderStyle = BorderStyle.FixedSingle;
            coinLivePrice3.FlatStyle = FlatStyle.Flat;
            coinLivePrice3.Location = new Point(237, 64);
            coinLivePrice3.Name = "coinLivePrice3";
            coinLivePrice3.Size = new Size(204, 52);
            coinLivePrice3.TabIndex = 2;
            coinLivePrice3.Text = "...";
            // 
            // coinPriceLabel3
            // 
            coinPriceLabel3.AutoSize = true;
            coinPriceLabel3.BackColor = Color.LimeGreen;
            coinPriceLabel3.Font = new Font("Segoe UI", 13.875F, FontStyle.Underline, GraphicsUnit.Point);
            coinPriceLabel3.Location = new Point(7, 64);
            coinPriceLabel3.Name = "coinPriceLabel3";
            coinPriceLabel3.Size = new Size(192, 50);
            coinPriceLabel3.TabIndex = 1;
            coinPriceLabel3.Text = "Live Price: ";
            // 
            // pairDisplayPanel4
            // 
            pairDisplayPanel4.BackColor = SystemColors.ActiveCaption;
            pairDisplayPanel4.Controls.Add(label6);
            pairDisplayPanel4.Controls.Add(currencySelectBox4);
            pairDisplayPanel4.Controls.Add(coinSelectBox4);
            pairDisplayPanel4.Controls.Add(historicalPriceListView4);
            pairDisplayPanel4.Controls.Add(coinLivePrice4);
            pairDisplayPanel4.Controls.Add(coinPriceLabel4);
            pairDisplayPanel4.Location = new Point(14, 434);
            pairDisplayPanel4.Margin = new Padding(5);
            pairDisplayPanel4.Name = "pairDisplayPanel4";
            pairDisplayPanel4.Size = new Size(445, 362);
            pairDisplayPanel4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(144, 125);
            label6.Name = "label6";
            label6.Size = new Size(165, 37);
            label6.TabIndex = 6;
            label6.Text = "Price History";
            // 
            // currencySelectBox4
            // 
            currencySelectBox4.FormattingEnabled = true;
            currencySelectBox4.Location = new Point(237, 3);
            currencySelectBox4.Name = "currencySelectBox4";
            currencySelectBox4.Size = new Size(204, 58);
            currencySelectBox4.TabIndex = 5;
            // 
            // coinSelectBox4
            // 
            coinSelectBox4.BackColor = SystemColors.Window;
            coinSelectBox4.FormattingEnabled = true;
            coinSelectBox4.Location = new Point(3, 3);
            coinSelectBox4.Name = "coinSelectBox4";
            coinSelectBox4.Size = new Size(196, 58);
            coinSelectBox4.TabIndex = 4;
            // 
            // historicalPriceListView4
            // 
            historicalPriceListView4.BackColor = SystemColors.ControlLight;
            historicalPriceListView4.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9 });
            historicalPriceListView4.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            historicalPriceListView4.Location = new Point(3, 165);
            historicalPriceListView4.Name = "historicalPriceListView4";
            historicalPriceListView4.Size = new Size(438, 194);
            historicalPriceListView4.TabIndex = 3;
            historicalPriceListView4.UseCompatibleStateImageBehavior = false;
            historicalPriceListView4.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Timestamp";
            columnHeader7.Width = 165;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Pair";
            columnHeader8.Width = 160;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Price";
            columnHeader9.Width = 108;
            // 
            // coinLivePrice4
            // 
            coinLivePrice4.BackColor = Color.LimeGreen;
            coinLivePrice4.BorderStyle = BorderStyle.FixedSingle;
            coinLivePrice4.FlatStyle = FlatStyle.Flat;
            coinLivePrice4.Location = new Point(237, 64);
            coinLivePrice4.Name = "coinLivePrice4";
            coinLivePrice4.Size = new Size(204, 52);
            coinLivePrice4.TabIndex = 2;
            coinLivePrice4.Text = "...";
            // 
            // coinPriceLabel4
            // 
            coinPriceLabel4.AutoSize = true;
            coinPriceLabel4.BackColor = Color.LimeGreen;
            coinPriceLabel4.Font = new Font("Segoe UI", 13.875F, FontStyle.Underline, GraphicsUnit.Point);
            coinPriceLabel4.Location = new Point(7, 64);
            coinPriceLabel4.Name = "coinPriceLabel4";
            coinPriceLabel4.Size = new Size(192, 50);
            coinPriceLabel4.TabIndex = 1;
            coinPriceLabel4.Text = "Live Price: ";
            // 
            // pairDisplayPanel5
            // 
            pairDisplayPanel5.BackColor = SystemColors.ActiveCaption;
            pairDisplayPanel5.Controls.Add(label9);
            pairDisplayPanel5.Controls.Add(currencySelectBox5);
            pairDisplayPanel5.Controls.Add(coinSelectBox5);
            pairDisplayPanel5.Controls.Add(historicalPriceListView5);
            pairDisplayPanel5.Controls.Add(coinLivePrice5);
            pairDisplayPanel5.Controls.Add(coinPriceLabel5);
            pairDisplayPanel5.Location = new Point(485, 434);
            pairDisplayPanel5.Margin = new Padding(5);
            pairDisplayPanel5.Name = "pairDisplayPanel5";
            pairDisplayPanel5.Size = new Size(445, 362);
            pairDisplayPanel5.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(144, 125);
            label9.Name = "label9";
            label9.Size = new Size(165, 37);
            label9.TabIndex = 6;
            label9.Text = "Price History";
            // 
            // currencySelectBox5
            // 
            currencySelectBox5.FormattingEnabled = true;
            currencySelectBox5.Location = new Point(237, 3);
            currencySelectBox5.Name = "currencySelectBox5";
            currencySelectBox5.Size = new Size(204, 58);
            currencySelectBox5.TabIndex = 5;
            // 
            // coinSelectBox5
            // 
            coinSelectBox5.BackColor = SystemColors.Window;
            coinSelectBox5.FormattingEnabled = true;
            coinSelectBox5.Location = new Point(3, 3);
            coinSelectBox5.Name = "coinSelectBox5";
            coinSelectBox5.Size = new Size(196, 58);
            coinSelectBox5.TabIndex = 4;
            // 
            // historicalPriceListView5
            // 
            historicalPriceListView5.BackColor = SystemColors.ControlLight;
            historicalPriceListView5.Columns.AddRange(new ColumnHeader[] { columnHeader10, columnHeader11, columnHeader12 });
            historicalPriceListView5.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            historicalPriceListView5.Location = new Point(3, 165);
            historicalPriceListView5.Name = "historicalPriceListView5";
            historicalPriceListView5.Size = new Size(438, 194);
            historicalPriceListView5.TabIndex = 3;
            historicalPriceListView5.UseCompatibleStateImageBehavior = false;
            historicalPriceListView5.View = View.Details;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Timestamp";
            columnHeader10.Width = 165;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Pair";
            columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Price";
            columnHeader12.Width = 108;
            // 
            // coinLivePrice5
            // 
            coinLivePrice5.BackColor = Color.LimeGreen;
            coinLivePrice5.BorderStyle = BorderStyle.FixedSingle;
            coinLivePrice5.FlatStyle = FlatStyle.Flat;
            coinLivePrice5.Location = new Point(237, 64);
            coinLivePrice5.Name = "coinLivePrice5";
            coinLivePrice5.Size = new Size(204, 52);
            coinLivePrice5.TabIndex = 2;
            coinLivePrice5.Text = "...";
            // 
            // coinPriceLabel5
            // 
            coinPriceLabel5.AutoSize = true;
            coinPriceLabel5.BackColor = Color.LimeGreen;
            coinPriceLabel5.Font = new Font("Segoe UI", 13.875F, FontStyle.Underline, GraphicsUnit.Point);
            coinPriceLabel5.Location = new Point(7, 64);
            coinPriceLabel5.Name = "coinPriceLabel5";
            coinPriceLabel5.Size = new Size(192, 50);
            coinPriceLabel5.TabIndex = 1;
            coinPriceLabel5.Text = "Live Price: ";
            // 
            // pairDisplayPanel6
            // 
            pairDisplayPanel6.BackColor = SystemColors.ActiveCaption;
            pairDisplayPanel6.Controls.Add(label12);
            pairDisplayPanel6.Controls.Add(currencySelectBox6);
            pairDisplayPanel6.Controls.Add(coinSelectBox6);
            pairDisplayPanel6.Controls.Add(historicalPriceListView6);
            pairDisplayPanel6.Controls.Add(coinLivePrice6);
            pairDisplayPanel6.Controls.Add(coinPriceLabel6);
            pairDisplayPanel6.Location = new Point(960, 434);
            pairDisplayPanel6.Margin = new Padding(5);
            pairDisplayPanel6.Name = "pairDisplayPanel6";
            pairDisplayPanel6.Size = new Size(445, 362);
            pairDisplayPanel6.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(144, 125);
            label12.Name = "label12";
            label12.Size = new Size(165, 37);
            label12.TabIndex = 6;
            label12.Text = "Price History";
            // 
            // currencySelectBox6
            // 
            currencySelectBox6.FormattingEnabled = true;
            currencySelectBox6.Location = new Point(237, 3);
            currencySelectBox6.Name = "currencySelectBox6";
            currencySelectBox6.Size = new Size(204, 58);
            currencySelectBox6.TabIndex = 5;
            // 
            // coinSelectBox6
            // 
            coinSelectBox6.BackColor = SystemColors.Window;
            coinSelectBox6.FormattingEnabled = true;
            coinSelectBox6.Location = new Point(3, 3);
            coinSelectBox6.Name = "coinSelectBox6";
            coinSelectBox6.Size = new Size(196, 58);
            coinSelectBox6.TabIndex = 4;
            // 
            // historicalPriceListView6
            // 
            historicalPriceListView6.BackColor = SystemColors.ControlLight;
            historicalPriceListView6.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14, columnHeader15 });
            historicalPriceListView6.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            historicalPriceListView6.Location = new Point(3, 165);
            historicalPriceListView6.Name = "historicalPriceListView6";
            historicalPriceListView6.Size = new Size(438, 194);
            historicalPriceListView6.TabIndex = 3;
            historicalPriceListView6.UseCompatibleStateImageBehavior = false;
            historicalPriceListView6.View = View.Details;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Timestamp";
            columnHeader13.Width = 165;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Pair";
            columnHeader14.Width = 160;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Price";
            columnHeader15.Width = 108;
            // 
            // coinLivePrice6
            // 
            coinLivePrice6.BackColor = Color.LimeGreen;
            coinLivePrice6.BorderStyle = BorderStyle.FixedSingle;
            coinLivePrice6.FlatStyle = FlatStyle.Flat;
            coinLivePrice6.Location = new Point(237, 64);
            coinLivePrice6.Name = "coinLivePrice6";
            coinLivePrice6.Size = new Size(204, 52);
            coinLivePrice6.TabIndex = 2;
            coinLivePrice6.Text = "...";
            // 
            // coinPriceLabel6
            // 
            coinPriceLabel6.AutoSize = true;
            coinPriceLabel6.BackColor = Color.LimeGreen;
            coinPriceLabel6.Font = new Font("Segoe UI", 13.875F, FontStyle.Underline, GraphicsUnit.Point);
            coinPriceLabel6.Location = new Point(7, 64);
            coinPriceLabel6.Name = "coinPriceLabel6";
            coinPriceLabel6.Size = new Size(192, 50);
            coinPriceLabel6.TabIndex = 1;
            coinPriceLabel6.Text = "Live Price: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 559);
            Controls.Add(updateButton);
            Controls.Add(pairDisplayPanel6);
            Controls.Add(pairDisplayPanel5);
            Controls.Add(pairDisplayPanel4);
            Controls.Add(pairDisplayPanel3);
            Controls.Add(pairDisplayPanel2);
            Controls.Add(statusStrip1);
            Controls.Add(pairDisplayPanel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Live Price Tracker";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pairDisplayPanel1.ResumeLayout(false);
            pairDisplayPanel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pairDisplayPanel2.ResumeLayout(false);
            pairDisplayPanel2.PerformLayout();
            pairDisplayPanel3.ResumeLayout(false);
            pairDisplayPanel3.PerformLayout();
            pairDisplayPanel4.ResumeLayout(false);
            pairDisplayPanel4.PerformLayout();
            pairDisplayPanel5.ResumeLayout(false);
            pairDisplayPanel5.PerformLayout();
            pairDisplayPanel6.ResumeLayout(false);
            pairDisplayPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel pairDisplayPanel1;
        private Label coinPriceLabel1;
        private Label coinLivePrice1;
        private ComboBox currencySelectBox1;
        private ComboBox coinSelectBox1;
        private ListView historicalPriceListView1;
        private Label label1;
        private ColumnHeader Timestamp;
        private ColumnHeader Pair;
        private ColumnHeader Price;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar apiRateLimitProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pairDisplayPanel2;
        private Label label2;
        private ComboBox currencySelectBox2;
        private ComboBox coinSelectBox2;
        private ListView historicalPriceListView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label coinLivePrice2;
        private Label coinPriceLabel2;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripComboBox panelNumberComboBox;
        private Panel pairDisplayPanel3;
        private Label label3;
        private ComboBox currencySelectBox3;
        private ComboBox coinSelectBox3;
        private ListView historicalPriceListView3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label coinLivePrice3;
        private Label coinPriceLabel3;
        private Panel pairDisplayPanel4;
        private Label label6;
        private ComboBox currencySelectBox4;
        private ComboBox coinSelectBox4;
        private ListView historicalPriceListView4;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label coinLivePrice4;
        private Label coinPriceLabel4;
        private Panel pairDisplayPanel5;
        private Label label9;
        private ComboBox currencySelectBox5;
        private ComboBox coinSelectBox5;
        private ListView historicalPriceListView5;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label coinLivePrice5;
        private Label coinPriceLabel5;
        private Panel pairDisplayPanel6;
        private Label label12;
        private ComboBox currencySelectBox6;
        private ComboBox coinSelectBox6;
        private ListView historicalPriceListView6;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private Label coinLivePrice6;
        private Label coinPriceLabel6;
    }

}