namespace ContactsAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SearchBox = new TextBox();
            label1 = new Label();
            ContactsList = new ListBox();
            LastNameBox = new TextBox();
            label2 = new Label();
            NameBox = new TextBox();
            BirthdayBox = new TextBox();
            PhoneBox = new TextBox();
            EMailBox = new TextBox();
            VkBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            addContactToolStripMenuItem = new ToolStripMenuItem();
            editContactToolStripMenuItem = new ToolStripMenuItem();
            removeContactToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            AddContactButton = new Button();
            EditContactButton = new Button();
            RemoveContactButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(92, 51);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(100, 23);
            SearchBox.TabIndex = 0;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 54);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Find";
            // 
            // ContactsList
            // 
            ContactsList.FormattingEnabled = true;
            ContactsList.ItemHeight = 15;
            ContactsList.Location = new Point(88, 89);
            ContactsList.Name = "ContactsList";
            ContactsList.Size = new Size(120, 214);
            ContactsList.Sorted = true;
            ContactsList.TabIndex = 2;
            ContactsList.SelectedIndexChanged += ContactsList_SelectedIndexChanged;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(592, 74);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(100, 23);
            LastNameBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 77);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(592, 126);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(100, 23);
            NameBox.TabIndex = 5;
            // 
            // BirthdayBox
            // 
            BirthdayBox.Location = new Point(592, 185);
            BirthdayBox.Name = "BirthdayBox";
            BirthdayBox.Size = new Size(100, 23);
            BirthdayBox.TabIndex = 6;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(592, 240);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(100, 23);
            PhoneBox.TabIndex = 7;
            // 
            // EMailBox
            // 
            EMailBox.Location = new Point(592, 296);
            EMailBox.Name = "EMailBox";
            EMailBox.Size = new Size(100, 23);
            EMailBox.TabIndex = 8;
            // 
            // VkBox
            // 
            VkBox.Location = new Point(592, 348);
            VkBox.Name = "VkBox";
            VkBox.Size = new Size(100, 23);
            VkBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(511, 129);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 10;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(511, 188);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 11;
            label4.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(511, 243);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 299);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 13;
            label6.Text = "E-Mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(511, 351);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 14;
            label7.Text = "Vk.com";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addContactToolStripMenuItem, editContactToolStripMenuItem, removeContactToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            addContactToolStripMenuItem.Size = new Size(162, 22);
            addContactToolStripMenuItem.Text = "Add Contact";
            addContactToolStripMenuItem.Click += AddContactToolStripMenuItem_Click;
            // 
            // editContactToolStripMenuItem
            // 
            editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            editContactToolStripMenuItem.Size = new Size(162, 22);
            editContactToolStripMenuItem.Text = "Edit Contact";
            editContactToolStripMenuItem.Click += EditContactToolStripMenuItem_Click;
            // 
            // removeContactToolStripMenuItem
            // 
            removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            removeContactToolStripMenuItem.Size = new Size(162, 22);
            removeContactToolStripMenuItem.Text = "Remove Contact";
            removeContactToolStripMenuItem.Click += RemoveContactToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += HelpToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // AddContactButton
            // 
            AddContactButton.Image = (Image)resources.GetObject("AddContactButton.Image");
            AddContactButton.Location = new Point(54, 371);
            AddContactButton.Name = "AddContactButton";
            AddContactButton.Size = new Size(53, 23);
            AddContactButton.TabIndex = 16;
            AddContactButton.UseVisualStyleBackColor = true;
            AddContactButton.Click += AddContactButton_Click;
            // 
            // EditContactButton
            // 
            EditContactButton.Location = new Point(160, 371);
            EditContactButton.Name = "EditContactButton";
            EditContactButton.Size = new Size(75, 23);
            EditContactButton.TabIndex = 17;
            EditContactButton.Text = "EDIT";
            EditContactButton.UseVisualStyleBackColor = true;
            EditContactButton.Click += EditContactButton_Click;
            // 
            // RemoveContactButton
            // 
            RemoveContactButton.Image = (Image)resources.GetObject("RemoveContactButton.Image");
            RemoveContactButton.Location = new Point(275, 371);
            RemoveContactButton.Name = "RemoveContactButton";
            RemoveContactButton.Size = new Size(53, 23);
            RemoveContactButton.TabIndex = 18;
            RemoveContactButton.UseVisualStyleBackColor = true;
            RemoveContactButton.Click += RemoveContactButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveContactButton);
            Controls.Add(EditContactButton);
            Controls.Add(AddContactButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(VkBox);
            Controls.Add(EMailBox);
            Controls.Add(PhoneBox);
            Controls.Add(BirthdayBox);
            Controls.Add(NameBox);
            Controls.Add(label2);
            Controls.Add(LastNameBox);
            Controls.Add(ContactsList);
            Controls.Add(label1);
            Controls.Add(SearchBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm__Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox SearchBox;
        private Label label1;
        private ListBox ContactsList;
        public TextBox LastNameBox;
        private Label label2;
        private TextBox NameBox;
        private TextBox BirthdayBox;
        private TextBox PhoneBox;
        private TextBox EMailBox;
        private TextBox VkBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem addContactToolStripMenuItem;
        private ToolStripMenuItem editContactToolStripMenuItem;
        private ToolStripMenuItem removeContactToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        public Button AddContactButton;
        private Button EditContactButton;
        private Button RemoveContactButton;
    }
}
