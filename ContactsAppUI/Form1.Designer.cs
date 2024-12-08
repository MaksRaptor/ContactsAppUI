namespace ContactsAppUI
{
  partial class AddEdit
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            VkBox = new TextBox();
            EMailBox = new TextBox();
            NameBox = new TextBox();
            label2 = new Label();
            LastNameBox = new TextBox();
            OkButton = new Button();
            CancelButton = new Button();
            MaskedPhoneBox = new MaskedTextBox();
            MaskedBirthdayBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 314);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 26;
            label7.Text = "Vk.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 262);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 25;
            label6.Text = "E-Mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 206);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 24;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 151);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 23;
            label4.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 92);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 22;
            label3.Text = "Name";
            // 
            // VkBox
            // 
            VkBox.Location = new Point(112, 311);
            VkBox.Name = "VkBox";
            VkBox.Size = new Size(100, 23);
            VkBox.TabIndex = 21;
            VkBox.TextChanged += VkBox_TextChanged;
            // 
            // EMailBox
            // 
            EMailBox.Location = new Point(112, 259);
            EMailBox.Name = "EMailBox";
            EMailBox.Size = new Size(100, 23);
            EMailBox.TabIndex = 20;
            EMailBox.TextChanged += EMailBox_TextChanged;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(112, 89);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 17;
            NameBox.TextChanged += NameBox_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 16;
            label2.Text = "Surname";
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(112, 37);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(100, 23);
            LastNameBox.TabIndex = 15;
            LastNameBox.TextChanged += LastNameBox_TextChanged;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(53, 402);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 27;
            OkButton.Text = "OK";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(181, 402);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 28;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // MaskedPhoneBox
            // 
            MaskedPhoneBox.Location = new Point(112, 198);
            MaskedPhoneBox.Mask = "70000000000";
            MaskedPhoneBox.Name = "MaskedPhoneBox";
            MaskedPhoneBox.PromptChar = ' ';
            MaskedPhoneBox.Size = new Size(100, 23);
            MaskedPhoneBox.TabIndex = 29;
            // 
            // MaskedBirthdayBox
            // 
            MaskedBirthdayBox.Location = new Point(112, 143);
            MaskedBirthdayBox.Mask = "00/00/0000";
            MaskedBirthdayBox.Name = "MaskedBirthdayBox";
            MaskedBirthdayBox.PromptChar = ' ';
            MaskedBirthdayBox.Size = new Size(100, 23);
            MaskedBirthdayBox.TabIndex = 30;
            MaskedBirthdayBox.MaskInputRejected += MaskedBirthdayBox_MaskInputRejected;
            // 
            // AddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MaskedBirthdayBox);
            Controls.Add(MaskedPhoneBox);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(VkBox);
            Controls.Add(EMailBox);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(LastNameBox);
            Name = "AddEdit";
            Text = "Add/Edit";
            Load += AddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        public TextBox VkBox;
        public TextBox EMailBox;
        public TextBox NameBox;
        private Label label2;
        public TextBox LastNameBox;
        private Button OkButton;
        private Button CancelButton;
        public MaskedTextBox MaskedPhoneBox;
        public MaskedTextBox MaskedBirthdayBox;
    }
}