using System.CodeDom.Compiler;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using ContactsApp;
using System.Windows.Forms;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������������� �������� �����
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
             
        }


        /// <summary>
        /// �������� �������� �����
        /// </summary>

        private void MainForm__Load(object sender, EventArgs e)
        {
            var project = new Project();
            var contact1 = new Contact();

            ///<summary>
            /// ���� ����� ��� - ������� ������
            /// </summary>

            if (!File.Exists(ContactsApp.My_Constants.WholePath))
            {
                File.Create(ContactsApp.My_Constants.WholePath);
                return;
            }

            ///<summary>
            /// ������� ContactsList � �������� ������ ��������� �� �����
            /// </summary>
            /// 
            ContactsList.Items.Clear();

            ContactsList.BeginUpdate();

            project = ContactsApp.ProjectManager.LoadContactListFromFile();

            ///<summary>
            ///�������� ���������  (�� ������) � ContactsList
            /// </summary>
            if (project.ContactsList.Count > 0)
            {
                for (int i = 0; i < project.ContactsList.Count; i++)
                {
                    ContactsList.Items.Add(project.ContactsList[i].LastName);
                }

                ContactsList.Sorted = true;

                if (ContactsList.Items.Count > 0)
            {
                ContactsList.SelectedIndex = 0;
            }


                ContactsList.EndUpdate();

            /// <summary>
            /// ����� ���������� ��������
            /// </summary> 


                contact1 = ContactsApp.ProjectManager.SearchForContact(ContactsList.SelectedItem.ToString());

            //. <summary>
            ///  ���������� ����� ���������� ��������
            /// </summary>

                LastNameBox.Text = contact1.LastName;

                NameBox.Text = contact1.FirstName;

                BirthdayBox.Text = contact1.Birthday;

                PhoneBox.Text = contact1.Phone;

                EMailBox.Text = contact1.Email;

                VkBox.Text = contact1.VkId;

                }
    }


            /// <summary>
            /// ��������� ������� ��������� �������� �������� � ListBox'�
            /// </summary> 

        private void ContactsList_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ContactsList.SelectedIndex != -1)
            {
                var contact1 = new Contact();

                contact1 = ContactsApp.ProjectManager.SearchForContact(ContactsList.SelectedItem.ToString());

                LastNameBox.Text = contact1.LastName;

                NameBox.Text = contact1.FirstName;

                BirthdayBox.Text = contact1.Birthday;

                PhoneBox.Text = contact1.Phone;

                EMailBox.Text = contact1.Email;

                VkBox.Text = contact1.VkId;

            }
        }
            /// <summary>
            /// ��������� ������ ������ ���� "Exit" (���������� ������)
            /// </summary> 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            /// <summary>
            /// ��������� ������ ������ ���� "Add Contact" (���������� ��������)
            /// </summary> 
        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit newform = new AddEdit();
            newform.Show();
            newform.Closing += AddEdit_Closing;
        }
            /// <summary>
            /// ��������� ������ ������ ���� "Edit Contact" (�������������� ��������)
            /// </summary> 
        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit newform = new AddEdit();

            PopulateContactDataFromTextBoxesForEditing(newform);
            newform.Show();
            newform.Closing += AddEdit_Closing;
        }

            /// <summary>
            /// ��������� ������ ������ ���� "Remove Contact" (�������� ��������)
            /// </summary> 
        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {   Contact contact2 = new Contact(); 
            Project project2 = new Project();

            DialogResult result = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                project2 = ContactsApp.ProjectManager.LoadContactListFromFile();
                contact2 = ContactsApp.ProjectManager.SearchForContact(LastNameBox.Text);

                for (int j = 0; j < project2.ContactsList.Count; j++)
                {
                    if (project2.ContactsList[j].LastName == LastNameBox.Text)
                    {
                        contact2 = project2.ContactsList[j];
                    }

                }

                if (project2.ContactsList.Remove(contact2) == true)
                {
                    File.WriteAllText(ContactsApp.My_Constants.WholePath, string.Empty);
                    ContactsApp.ProjectManager.SaveContactListToFile(project2);
                }

                ContactsList.Items.Clear();

                ContactsList.BeginUpdate();

                project2 = ContactsApp.ProjectManager.LoadContactListFromFile();

                ///<summary>
                ///�������� ���������  (�� ������) � ContactsList
                /// </summary>
                if (project2.ContactsList.Count > 0)
                {
                    for (int i = 0; i < project2.ContactsList.Count; i++)
                    {
                        ContactsList.Items.Add(project2.ContactsList[i].LastName);
                    }

                    ContactsList.Sorted = true;

                    if (ContactsList.Items.Count > 0)
                    {
                        ContactsList.SelectedIndex = 0;
                    }


                    ContactsList.EndUpdate();
                }

            }
            }
            
            /// <summary>
            /// ��������� ������ ������ ���� "Help" (����� ���� � ����������� � ���������)
            /// </summary> 
            private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newform = new About();
            newform.Show();
        }

        /// <summary>
        /// ��������� ������� ������ ���������� �������� (����)
        /// </summary> 

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            AddEdit newform = new AddEdit();
            newform.MaskedBirthdayBox.Text = "01.01.2000";
            newform.Show();
            newform.Closing += AddEdit_Closing;
        }

        /// <summary>
            /// ��������� ������� ������ �������������� �������� (EDIT)
            /// </summary> 
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            AddEdit newform = new AddEdit();
            PopulateContactDataFromTextBoxesForEditing(newform);
            newform.Show();
            newform.Closing += AddEdit_Closing;
        }

            /// <summary>
            /// ��������� ������� ������ �������� �������� (�����)
            /// </summary> 
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            Contact contact2 = new Contact();
            Project project2 = new Project();
            DialogResult result = MessageBox.Show("Are you sure?", "Question", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                project2 = ContactsApp.ProjectManager.LoadContactListFromFile();
                contact2 = ContactsApp.ProjectManager.SearchForContact(LastNameBox.Text);
                
                for (int j = 0;j < project2.ContactsList.Count; j++ )
                    {
                        if (project2.ContactsList[j].LastName == LastNameBox.Text)
                        {
                            contact2 = project2.ContactsList[j];
                        }
                    
                    }
               
                if (project2.ContactsList.Remove(contact2) == true)
                {
                    File.WriteAllText(ContactsApp.My_Constants.WholePath,string.Empty);
                    ContactsApp.ProjectManager.SaveContactListToFile(project2);
                }

                ContactsList.Items.Clear();

                ContactsList.BeginUpdate();

                project2 = ContactsApp.ProjectManager.LoadContactListFromFile();

                ///<summary>
                ///�������� ���������  (�� ������) � ContactsList
                /// </summary>
                if (project2.ContactsList.Count > 0)
                {
                    for (int i = 0; i < project2.ContactsList.Count; i++)
                    {
                        ContactsList.Items.Add(project2.ContactsList[i].LastName);
                    }

                    ContactsList.Sorted = true;

                    if (ContactsList.Items.Count > 0)
                    {
                        ContactsList.SelectedIndex = 0;
                    }


                    ContactsList.EndUpdate();
                }


            }
            }
            /// <summary>
            /// ���������� ����� ���������� ����� ��� ������������ �������������� ��������
            /// </summary> 
        private void PopulateContactDataFromTextBoxesForEditing(AddEdit form)
        {
            form.LastNameBox.Text = LastNameBox.Text;
            form.NameBox.Text = NameBox.Text;
            form.MaskedBirthdayBox.Text = BirthdayBox.Text;
            form.MaskedPhoneBox.Text = PhoneBox.Text;
            form.EMailBox.Text = EMailBox.Text;
            form.VkBox.Text = VkBox.Text;
        }

        /// <summary>
        /// ��������� �������� �����
        /// </summary>

        private void MainForm__Closing(object sender, EventArgs e)
        {
            Project project = new Project();
            if (ContactsList.Items.Count != 0)
            {
                for (int i = 0; i < ContactsList.Items.Count; i++)
                {
                    ContactsList.SelectedItem = i;
                    project.ContactsList[i].LastName = LastNameBox.Text;
                    project.ContactsList[i].FirstName = NameBox.Text;
                    project.ContactsList[i].Birthday = BirthdayBox.Text;
                    project.ContactsList[i].Phone = PhoneBox.Text;
                    project.ContactsList[i].Email = EMailBox.Text;
                    project.ContactsList[i].VkId = VkBox.Text;
                }
                File.WriteAllText(ContactsApp.My_Constants.WholePath, string.Empty);
                ContactsApp.ProjectManager.SaveContactListToFile(project);
            }
        }

        private void AddEdit_Closing(object sender, EventArgs e)
        {
            Project project = new Project();
            
            ContactsList.Items.Clear();

            ContactsList.BeginUpdate();

            project = ContactsApp.ProjectManager.LoadContactListFromFile();

            ///<summary>
            ///�������� ���������  (�� ������) � ContactsList
            /// </summary>
            if (project.ContactsList.Count > 0)
            {
                for (int i = 0; i < project.ContactsList.Count; i++)
                {
                    ContactsList.Items.Add(project.ContactsList[i].LastName);
                }

                ContactsList.Sorted = true;

                if (ContactsList.Items.Count > 0)
                {
                    ContactsList.SelectedIndex = 0;
                }
                
                ContactsList.EndUpdate();
            }
        }

        private void MainForm__Close(object sender, EventArgs e)
        {
            this.Closing += MainForm__Closing;
        }
    }
}
