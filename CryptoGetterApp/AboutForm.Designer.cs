namespace MyCryptoApp
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            whatLabel = new Label();
            whyLabel = new Label();
            howLabel = new Label();
            whatTextBox = new TextBox();
            howTextBox = new TextBox();
            textBox1 = new TextBox();
            closeButton = new Button();
            SuspendLayout();
            // 
            // whatLabel
            // 
            whatLabel.AutoSize = true;
            whatLabel.Location = new Point(12, 9);
            whatLabel.Margin = new Padding(5, 0, 5, 0);
            whatLabel.Name = "whatLabel";
            whatLabel.Size = new Size(128, 50);
            whatLabel.TabIndex = 0;
            whatLabel.Text = "What: ";
            // 
            // whyLabel
            // 
            whyLabel.AutoSize = true;
            whyLabel.Location = new Point(12, 163);
            whyLabel.Name = "whyLabel";
            whyLabel.Size = new Size(114, 50);
            whyLabel.TabIndex = 1;
            whyLabel.Text = "Why: ";
            // 
            // howLabel
            // 
            howLabel.AutoSize = true;
            howLabel.Location = new Point(15, 365);
            howLabel.Name = "howLabel";
            howLabel.Size = new Size(115, 50);
            howLabel.TabIndex = 2;
            howLabel.Text = "How: ";
            // 
            // whatTextBox
            // 
            whatTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            whatTextBox.Location = new Point(134, 9);
            whatTextBox.Multiline = true;
            whatTextBox.Name = "whatTextBox";
            whatTextBox.ReadOnly = true;
            whatTextBox.Size = new Size(844, 151);
            whatTextBox.TabIndex = 0;
            whatTextBox.Text = "This is a Win Forms application using .Net (CORE). It utilizes CoinGecko's free tier API service to pull live price information for Coin/Currency Pairs.";
            // 
            // howTextBox
            // 
            howTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            howTextBox.Location = new Point(132, 166);
            howTextBox.Multiline = true;
            howTextBox.Name = "howTextBox";
            howTextBox.ReadOnly = true;
            howTextBox.Size = new Size(842, 194);
            howTextBox.TabIndex = 3;
            howTextBox.Text = resources.GetString("howTextBox.Text");
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(136, 366);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(842, 475);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom;
            closeButton.Location = new Point(377, 855);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(232, 100);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 967);
            Controls.Add(closeButton);
            Controls.Add(textBox1);
            Controls.Add(howTextBox);
            Controls.Add(whatTextBox);
            Controls.Add(howLabel);
            Controls.Add(whyLabel);
            Controls.Add(whatLabel);
            Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label whatLabel;
        private Label whyLabel;
        private Label howLabel;
        private TextBox whatTextBox;
        private TextBox howTextBox;
        private TextBox textBox1;
        private Button closeButton;
    }
}