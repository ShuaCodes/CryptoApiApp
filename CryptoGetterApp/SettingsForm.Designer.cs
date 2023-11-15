namespace MyCryptoApp
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            uriLabel = new Label();
            uriTextBox = new TextBox();
            textBox1 = new TextBox();
            rateLimitLabel = new Label();
            apiRateUsedTextBox = new TextBox();
            rateConsumedLabel = new Label();
            apiDocsLabel = new Label();
            apiDocsLinkLabel = new LinkLabel();
            closeButton = new Button();
            refreshDelayLabel = new Label();
            numericUpDown1 = new NumericUpDown();
            minuteLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // uriLabel
            // 
            uriLabel.AutoSize = true;
            uriLabel.BackColor = SystemColors.Control;
            uriLabel.Location = new Point(170, 51);
            uriLabel.Margin = new Padding(5, 0, 5, 0);
            uriLabel.Name = "uriLabel";
            uriLabel.Size = new Size(114, 50);
            uriLabel.TabIndex = 0;
            uriLabel.Text = "URI =";
            // 
            // uriTextBox
            // 
            uriTextBox.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            uriTextBox.Location = new Point(280, 51);
            uriTextBox.Name = "uriTextBox";
            uriTextBox.ReadOnly = true;
            uriTextBox.Size = new Size(360, 43);
            uriTextBox.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 202);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(360, 57);
            textBox1.TabIndex = 3;
            textBox1.Text = "10 Calls per Minute";
            // 
            // rateLimitLabel
            // 
            rateLimitLabel.AutoSize = true;
            rateLimitLabel.BackColor = SystemColors.Control;
            rateLimitLabel.Location = new Point(62, 209);
            rateLimitLabel.Margin = new Padding(5, 0, 5, 0);
            rateLimitLabel.Name = "rateLimitLabel";
            rateLimitLabel.Size = new Size(240, 50);
            rateLimitLabel.TabIndex = 2;
            rateLimitLabel.Text = "Rate Limit =  ";
            // 
            // apiRateUsedTextBox
            // 
            apiRateUsedTextBox.Location = new Point(280, 288);
            apiRateUsedTextBox.Name = "apiRateUsedTextBox";
            apiRateUsedTextBox.ReadOnly = true;
            apiRateUsedTextBox.Size = new Size(360, 57);
            apiRateUsedTextBox.TabIndex = 5;
            // 
            // rateConsumedLabel
            // 
            rateConsumedLabel.AutoSize = true;
            rateConsumedLabel.BackColor = SystemColors.Control;
            rateConsumedLabel.Location = new Point(62, 295);
            rateConsumedLabel.Margin = new Padding(5, 0, 5, 0);
            rateConsumedLabel.Name = "rateConsumedLabel";
            rateConsumedLabel.Size = new Size(232, 50);
            rateConsumedLabel.TabIndex = 4;
            rateConsumedLabel.Text = "Rate Used = ";
            // 
            // apiDocsLabel
            // 
            apiDocsLabel.AutoSize = true;
            apiDocsLabel.BackColor = SystemColors.Control;
            apiDocsLabel.Location = new Point(62, 375);
            apiDocsLabel.Margin = new Padding(5, 0, 5, 0);
            apiDocsLabel.Name = "apiDocsLabel";
            apiDocsLabel.Size = new Size(240, 50);
            apiDocsLabel.TabIndex = 6;
            apiDocsLabel.Text = "Rate Limit =  ";
            // 
            // apiDocsLinkLabel
            // 
            apiDocsLinkLabel.AccessibleRole = AccessibleRole.IpAddress;
            apiDocsLinkLabel.AutoSize = true;
            apiDocsLinkLabel.BackColor = SystemColors.Control;
            apiDocsLinkLabel.Location = new Point(280, 375);
            apiDocsLinkLabel.Name = "apiDocsLinkLabel";
            apiDocsLinkLabel.Size = new Size(342, 50);
            apiDocsLinkLabel.TabIndex = 7;
            apiDocsLinkLabel.TabStop = true;
            apiDocsLinkLabel.Text = "API Documentation";
            apiDocsLinkLabel.LinkClicked += apiDocsLinkLabel_LinkClicked;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(280, 557);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(150, 60);
            closeButton.TabIndex = 8;
            closeButton.Text = "Save";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // refreshDelayLabel
            // 
            refreshDelayLabel.AutoSize = true;
            refreshDelayLabel.Location = new Point(5, 128);
            refreshDelayLabel.Name = "refreshDelayLabel";
            refreshDelayLabel.Size = new Size(279, 50);
            refreshDelayLabel.TabIndex = 9;
            refreshDelayLabel.Text = "Refresh Delay =";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(280, 126);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(246, 57);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // minuteLabel
            // 
            minuteLabel.AutoSize = true;
            minuteLabel.Location = new Point(524, 128);
            minuteLabel.Name = "minuteLabel";
            minuteLabel.Size = new Size(98, 50);
            minuteLabel.TabIndex = 11;
            minuteLabel.Text = "/min";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(751, 629);
            Controls.Add(minuteLabel);
            Controls.Add(numericUpDown1);
            Controls.Add(refreshDelayLabel);
            Controls.Add(closeButton);
            Controls.Add(apiDocsLinkLabel);
            Controls.Add(apiDocsLabel);
            Controls.Add(apiRateUsedTextBox);
            Controls.Add(rateConsumedLabel);
            Controls.Add(textBox1);
            Controls.Add(rateLimitLabel);
            Controls.Add(uriTextBox);
            Controls.Add(uriLabel);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(8, 9, 8, 9);
            MaximumSize = new Size(777, 700);
            MinimumSize = new Size(777, 540);
            Name = "SettingsForm";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label uriLabel;
        private TextBox uriTextBox;
        private TextBox textBox1;
        private Label rateLimitLabel;
        private TextBox apiRateUsedTextBox;
        private Label rateConsumedLabel;
        private Label apiDocsLabel;
        private LinkLabel apiDocsLinkLabel;
        private Button closeButton;
        private Label refreshDelayLabel;
        private NumericUpDown numericUpDown1;
        private Label minuteLabel;
    }
}
