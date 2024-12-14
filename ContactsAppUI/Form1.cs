using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Diagnostics.Contracts;


namespace ContactsAppUI
{
    public partial class AddEdit : Form
    {
        const string start = "1900.01.01";
        Contact contact = new Contact();
        Project project = new Project();
        int i = 0;
        bool AddNotEdit = true;

        /// <summary>
        /// Инициализация внутренней (добавление/редактирование) формы
        /// </summary>
        public AddEdit()
        {

            InitializeComponent();

        }

        /// <summary>
        /// Опции сериализации Json
        /// </summary>

        private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All), // Вот эта строка Вам поможет с кодировкой
            WriteIndented = true
        };
        /// <summary>
        ///Обработка нажатия кнопки "OK" во внутренней форме
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            Contact contact1 = new Contact();


            if (AddNotEdit == true)

            ///<summary>
            ///Добавление нового контакта, добавляем в хвост списка
            /// </summary>

            {
                contact1.LastName = LastNameBox.Text;
                contact1.FirstName = NameBox.Text;
                contact1.Birthday = MaskedBirthdayBox.Text;
                contact1.Phone = MaskedPhoneBox.Text;
                contact1.Email = EMailBox.Text;
                contact1.VkId = VkBox.Text;
                project.ContactsList.Add(contact1);

                File.WriteAllText(ContactsApp.My_Constants.WholePath, string.Empty);
                
                
                ContactsApp.ProjectManager.SaveContactListToFile(project);
                this.Close();
                return;
            }
            else

            ///<summary>
            ///Редактирование контакта, заменяем
            /// </summary>

            {
                contact1.LastName = LastNameBox.Text;
                contact1.FirstName = NameBox.Text;
                contact1.Birthday = MaskedBirthdayBox.Text;
                contact1.Phone = MaskedPhoneBox.Text;
                contact1.Email = EMailBox.Text;
                contact1.VkId = VkBox.Text;
                
                project.ContactsList[i] = contact1;
                File.WriteAllText(ContactsApp.My_Constants.WholePath, string.Empty);
                ContactsApp.ProjectManager.SaveContactListToFile(project);
                this.Close();
                return;

            }

            
        }

        /// <summary>
        ///Обработка нажатия кнопки "Cancel" во внутренней форме (доработать!)
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///Обработка ввода/изменения фамилии во внутренней форме
        /// </summary>
        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LastNameBox.TextLength > 50) throw new Exception("Не более 50 символов!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LastNameBox.Text = LastNameBox.Text.ToString().Substring(0, 50);
            }

            LastNameBox.SelectionStart = LastNameBox.TextLength + 1;
            if (LastNameBox.TextLength > 0)
            {
                LastNameBox.Text = LastNameBox.Text.ToString().Substring(0, 1).ToUpper() +
                                LastNameBox.Text.ToString().Substring(1, LastNameBox.TextLength - 1);

            }


        }
        /// <summary>
        ///Обработка ввода/изменения идентификатора "В Контакте" во внутренней форме
        /// </summary>
        private void VkBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (VkBox.TextLength > 15) throw new Exception("Не более 15 символов!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                VkBox.Text = VkBox.Text.ToString().Substring(0, 15);
            }

            VkBox.SelectionStart = VkBox.TextLength + 1;

        }

        /// <summary>
        ///Обработка ввода/изменения фамилии во внутренней форме
        /// </summary>
        private void NameBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.TextLength > 50) throw new Exception("Не более 50 символов!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                NameBox.Text = NameBox.Text.ToString().Substring(0, 50);
            }

            NameBox.SelectionStart = NameBox.TextLength + 1;
            if (NameBox.TextLength > 0)
            {
                NameBox.Text = NameBox.Text.ToString().Substring(0, 1).ToUpper() +
                             NameBox.Text.ToString().Substring(1, NameBox.TextLength - 1);
            }
        }

        /// <summary>
        ///Обработка ввода/изменения EMail во внутренней форме
        /// </summary>

        private void EMailBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (EMailBox.TextLength > 50) throw new Exception("Не более 50 символов!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                EMailBox.Text = EMailBox.Text.ToString().Substring(0, 50);
            }

        }

        /// <summary>
        ///Обработка ввода/изменения даты рождения во внутренней форме
        /// </summary>
        private void MaskedBirthdayBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            DateTime now = DateTime.Now;
            string birthday = "", stringdata, newbirthday = "";
            stringdata = now.ToString("yyyy.MM.dd");
            MaskedBirthdayBox.SelectionStart = 0;
            birthday = (String)MaskedBirthdayBox.Text;
            if (birthday.Length == 10)
            {
                newbirthday = birthday.Substring(birthday.Length - 4, 4) + "." +
                              birthday.Substring(birthday.Length - 7, 2) + "." +
                              birthday.Substring(birthday.Length - 10, 2);
            }

            try
            {


                if (String.Compare(newbirthday, stringdata) > 0 || (String.Compare(newbirthday, start) < 0))
                    throw new Exception("неверная дата рождения!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MaskedBirthdayBox.Clear();
            }

        }

        private void AddEdit_Load(object sender, EventArgs e)
        { Contact contact =new Contact();

            contact.LastName = LastNameBox.Text;
            contact.FirstName = NameBox.Text;
            contact.Birthday = MaskedBirthdayBox.Text;
            contact.Phone = MaskedPhoneBox.Text;
            contact.Email = EMailBox.Text;
            contact.VkId = VkBox.Text;


            project = ContactsApp.ProjectManager.LoadContactListFromFile();

            
            if (contact.LastName != "")
            {
                for (int j = 0; j < project.ContactsList.Count; j++)
                {

                    if (contact.VkId == project.ContactsList[j].VkId)
                    {
                        i = j;
                    }
                }
                
            }
            
            if (LastNameBox.Text != "")
            {
                AddNotEdit = false;
            }
        }
    }
}
