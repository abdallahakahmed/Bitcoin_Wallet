namespace NbitcoinWallet
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGenerateSeed = new Button();
            lblPrivateKey = new Label();
            lblPrivateKeyAddress = new Label();
            label5 = new Label();
            btnaddress = new Label();
            lblMnemonic = new Label();
            lblAddressMnemonic = new Label();
            label = new Label();
            lblbalance1 = new Label();
            label6 = new Label();
            lblbalance2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(71, 38);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 0;
            label1.Text = "Generate Address by Private Key";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 84);
            button1.Name = "button1";
            button1.Size = new Size(190, 23);
            button1.TabIndex = 1;
            button1.Text = "Generate Via Private Key";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(71, 130);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 2;
            label2.Text = "Private Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(71, 167);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Address";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(71, 327);
            label4.Name = "label4";
            label4.Size = new Size(308, 25);
            label4.TabIndex = 6;
            label4.Text = "Generate Address by Seed Phrase";
            label4.Click += label4_Click;
            // 
            // btnGenerateSeed
            // 
            btnGenerateSeed.Location = new Point(71, 373);
            btnGenerateSeed.Name = "btnGenerateSeed";
            btnGenerateSeed.Size = new Size(188, 23);
            btnGenerateSeed.TabIndex = 7;
            btnGenerateSeed.Text = "Generate Via Seed Phrase";
            btnGenerateSeed.UseVisualStyleBackColor = true;
            btnGenerateSeed.Click += btnGenerateSeed_Click;
            // 
            // lblPrivateKey
            // 
            lblPrivateKey.AutoSize = true;
            lblPrivateKey.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrivateKey.ForeColor = SystemColors.ButtonHighlight;
            lblPrivateKey.Location = new Point(160, 132);
            lblPrivateKey.Name = "lblPrivateKey";
            lblPrivateKey.Size = new Size(0, 15);
            lblPrivateKey.TabIndex = 8;
            // 
            // lblPrivateKeyAddress
            // 
            lblPrivateKeyAddress.AutoSize = true;
            lblPrivateKeyAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrivateKeyAddress.ForeColor = SystemColors.ButtonHighlight;
            lblPrivateKeyAddress.Location = new Point(160, 169);
            lblPrivateKeyAddress.Name = "lblPrivateKeyAddress";
            lblPrivateKeyAddress.Size = new Size(0, 15);
            lblPrivateKeyAddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(71, 417);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 10;
            label5.Text = "Mnemonic";
            // 
            // btnaddress
            // 
            btnaddress.AutoSize = true;
            btnaddress.ForeColor = SystemColors.ButtonHighlight;
            btnaddress.Location = new Point(71, 458);
            btnaddress.Name = "btnaddress";
            btnaddress.Size = new Size(51, 15);
            btnaddress.TabIndex = 11;
            btnaddress.Text = "Address";
            // 
            // lblMnemonic
            // 
            lblMnemonic.AutoSize = true;
            lblMnemonic.Location = new Point(154, 417);
            lblMnemonic.Name = "lblMnemonic";
            lblMnemonic.Size = new Size(0, 15);
            lblMnemonic.TabIndex = 12;
            // 
            // lblAddressMnemonic
            // 
            lblAddressMnemonic.AutoSize = true;
            lblAddressMnemonic.Location = new Point(154, 458);
            lblAddressMnemonic.Name = "lblAddressMnemonic";
            lblAddressMnemonic.Size = new Size(0, 15);
            lblAddressMnemonic.TabIndex = 13;
            // 
            // label
            // 
            label.AutoSize = true;
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(71, 201);
            label.Name = "label";
            label.Size = new Size(50, 15);
            label.TabIndex = 14;
            label.Text = "Balance";
            label.Click += label6_Click;
            // 
            // lblbalance1
            // 
            lblbalance1.AutoSize = true;
            lblbalance1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblbalance1.ForeColor = SystemColors.ButtonHighlight;
            lblbalance1.Location = new Point(160, 203);
            lblbalance1.Name = "lblbalance1";
            lblbalance1.Size = new Size(0, 15);
            lblbalance1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(71, 494);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 16;
            label6.Text = "Balance";
            // 
            // lblbalance2
            // 
            lblbalance2.AutoSize = true;
            lblbalance2.Location = new Point(158, 494);
            lblbalance2.Name = "lblbalance2";
            lblbalance2.Size = new Size(0, 15);
            lblbalance2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(851, 560);
            Controls.Add(lblbalance2);
            Controls.Add(label6);
            Controls.Add(lblbalance1);
            Controls.Add(label);
            Controls.Add(lblAddressMnemonic);
            Controls.Add(lblMnemonic);
            Controls.Add(btnaddress);
            Controls.Add(label5);
            Controls.Add(lblPrivateKeyAddress);
            Controls.Add(lblPrivateKey);
            Controls.Add(btnGenerateSeed);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Main Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGenerateSeed;
        private Label lblPrivateKey;
        private Label lblPrivateKeyAddress;
        private Label label5;
        private Label btnaddress;
        private Label lblMnemonic;
        private Label lblAddressMnemonic;
        private Label label;
        private Label lblbalance1;
        private Label label6;
        private Label lblbalance2;
    }
}