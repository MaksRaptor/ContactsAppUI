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
        /// Инициализация основной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

        }


        /// <summary>
        /// Загрузка основной формы
        /// </summary>

        private void MainForm__Load(object sender, EventArgs e)
        {
            var project = new Project();
            var contact1 = new Contact();

            ///<summary>
            /// Если файла нет - создаем пустой
            /// </summary>

            if (File.Exists(ContactsApp.My_Constants.WholePath) == false)
            {
                var myfile = File.Create(ContactsApp.My_Constants.WholePath);
                myfile.Close();

            }

            ///<summary>
            /// Очищаем ContactsList и получаем список контактов из файла
            /// </summary>
            /// 
            
            ContactsList.Items.Clear();

            //ContactsList.BeginUpdate();

            project = ContactsApp.ProjectManager.LoadContactListFromFile();

            ///<summary>
            ///Загрузка контактов  (по одному) в ContactsList
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


                //ContactsList.EndUpdate();

                /// <summary>
                /// Поиск выбранного контакта
                /// </summary> 


                contact1 = ContactsApp.ProjectManager.SearchForContact(ContactsList.SelectedItem.ToString());

                //. <summary>
                ///  Заполнение полей выбранного контакта
                /// </summary>

                LastNameBox.Text = contact1.LastName;

                NameBox.Text = contact1.FirstName;

                BirthdayBox.Text = contact1.Birthday;

                PhoneBox.Text = contact1.Phone;

                EMailBox.Text = contact1.Email;

                VkBox.Text = contact1.VkId;


               Show();

                
               AnnounceBirthdays();


            }
        }


        /// <summary>
        /// Обработка события изменения текущего контакта в ListBox'е
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
        /// Обработка выбора пункта меню "Exit" (завершение работы)
        /// </summary> 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработка выбора пункта меню "Add Contact" (добавление контакта)
        /// </summary> 
        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit newform = new AddEdit();
            newform.Show();
            newform.Closing += AddEdit_Closing;
        }
        /// <summary>
        /// Обработка выбора пункта меню "Edit Contact" (редактирование контакта)
        /// </summary> 
        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit newform = new AddEdit();

            PopulateContactDataFromTextBoxesForEditing(newform);
            newform.Show();
            newform.Closing += AddEdit_Closing;
        }

        /// <summary>
        /// Обработка выбора пункта меню "Remove Contact" (удаление контакта)
        /// </summary> 
        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact contact2 = new Contact();
            Project project2 = new Project();
            if (ContactsList.Items.Count > 0) {
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
                if (ContactsList.Items.Count == 1)
                {
                    LastNameBox.Text = string.Empty;
                    NameBox.Text = string.Empty;
                    BirthdayBox.Text = string.Empty;
                    PhoneBox.Text = string.Empty;
                    EMailBox.Text = string.Empty;
                    VkBox.Text = string.Empty;
                }
                    ContactsList.Items.Clear();

                //ContactsList.BeginUpdate();

                project2 = ContactsApp.ProjectManager.LoadContactListFromFile();

                ///<summary>
                ///Загрузка контактов  (по одному) в ContactsList
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


                    //ContactsList.EndUpdate();
                }
            }
            }
        }

        /// <summary>
        /// Обработка выбора пункта меню "Help" (вывод окна с информацией о программе)
        /// </summary> 
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newform = new About();
            newform.Show();
        }

        /// <summary>
        /// Обработка нажатия кнопки добавления контакта (плюс)
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
        /// Обработка нажатия кнопки редактирования контакта (EDIT)
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
        /// Обработка нажатия кнопки удаления контакта (минус)
        /// </summary> 
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            Contact contact2 = new Contact();
            Project project2 = new Project();
            if (ContactsList.Items.Count > 0)
            {

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

                if (ContactsList.Items.Count == 1)
                {
                    LastNameBox.Text = string.Empty;
                    NameBox.Text = string.Empty;
                    BirthdayBox.Text=string.Empty;
                    PhoneBox.Text = string.Empty;
                    EMailBox.Text = string.Empty;
                    VkBox.Text = string.Empty;
                }

                ContactsList.Items.Clear();

                //ContactsList.BeginUpdate();

                project2 = ContactsApp.ProjectManager.LoadContactListFromFile();

                ///<summary>
                ///Загрузка контактов  (по одному) в ContactsList
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


                    //ContactsList.EndUpdate();
                }

            }

            }
        }
        /// <summary>
        /// Заполнение полей внутренней формы для последующего редактирования контакта
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
        /// Обработка закрытия формы
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

            //ContactsList.BeginUpdate();
            
            project = ContactsApp.ProjectManager.LoadContactListFromFile();
           

            ///<summary>
            ///Загрузка контактов  (по одному) в ContactsList
            /// </summary>
            
            if (project.ContactsList.Count > 0)
            {
                for (int i = 0; i < project.ContactsList.Count; i++)
                {
                    ContactsList.Items.Add(project.ContactsList[i].LastName);
                }
                ContactsList.SetSelected(0,true);
                ContactsList.Sorted = true;

                if (ContactsList.Items.Count > 0)
                {
                    ContactsList.SelectedIndex = 0;
                }

                //ContactsList.EndUpdate();

                

            }
           
            return;

        }

        private void AnnounceBirthdays()
        {
            DateTime thisday = DateTime.Today;
            Contact contact = new Contact();
            Project project = new Project();
            string temp1 = "";
            string temp2 = thisday.ToString("d").Substring(0, thisday.ToString("d").LastIndexOf("."));
            project = ContactsApp.ProjectManager.LoadContactListFromFile();

            for (int j = 0; j < project.ContactsList.Count; j++)
            {
                contact.LastName = project.ContactsList[j].LastName;
                contact.Birthday = project.ContactsList[j].Birthday;
                temp1 = contact.Birthday.Substring(0, contact.Birthday.LastIndexOf("."));

                if (string.Equals(temp1, temp2))
                {
                    MessageBox.Show(contact.LastName + " - день рождения!. Поздравляем!");
                }
            }
        }

        private void MainForm__Close(object sender, EventArgs e)
        {
            this.Closing += MainForm__Closing;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            int k = 0;

            Project project = new Project();
            if (ContactsList.SelectedIndex != -1)

            {
                k = ContactsList.SelectedIndex;
            }
            
            //ContactsList.BeginUpdate();

            project = ContactsApp.ProjectManager.LoadContactListFromFile();

            if (SearchBox.Text != "")
            {
                ContactsList.Items.Clear();
                
                for (int j = 0; j < project.ContactsList.Count; j++)

                {
                    if (project.ContactsList[j].LastName.ToString().Contains(SearchBox.Text))
                    {
                        ContactsList.Items.Add(project.ContactsList[j].LastName);
                    }

                    if (ContactsList.Items.Count == 0)
                    {
                        LastNameBox.Text = string.Empty;
                        NameBox.Text = string.Empty;
                        BirthdayBox.Text = string.Empty;
                        PhoneBox.Text = string.Empty;
                        EMailBox.Text = string.Empty;
                        VkBox.Text = string.Empty;
                    }
                    
                }
                
            }
            else
            {
                ContactsList.Items.Clear();

                for (int j = 0; j < project.ContactsList.Count; j++)
                {
                    ContactsList.Items.Add(project.ContactsList[j].LastName);
                }
            }

            if (ContactsList.Items.Count > 0)
            {
                ContactsList.SelectedIndex = ContactsList.Items.Count -1;

            }
            //ContactsList.EndUpdate();

        }
    }
}
