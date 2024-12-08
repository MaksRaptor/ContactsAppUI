using System.Dynamic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Collections.Generic;


namespace ContactsApp
{
    
    public class PhoneNumber
    {
        public string Phone_Number;
        public PhoneNumber (string p)
        {
            Phone_Number = p;
        }
    }
    public class Contact: ICloneable
    {
        public string? LastName {get; set; }
        public string? FirstName { get; set; }
        public string? Birthday { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? VkId { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

    }
    public class Project : List<Contact>
    {
        public  List<Contact> ContactsList;

        public Project()
        {
            ContactsList = new List<Contact>();
        }
    }

    public static class ProjectManager
    {
        public static string json { get; private set; }
        public static string json2 { get; private set; }

        
        /// <summary>
        /// Опции сериализации Json
        /// </summary>

        private static readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            AllowTrailingCommas = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        public static Project LoadContactListFromFile()
        {
            json = File.ReadAllText(ContactsApp.My_Constants.WholePath);
            json2 = new string(json);
            Contact contact = new Contact();
            Project project = new Project();

            /// <summary>
            ///Получение списка контактов 
            /// </summary>
            /// 
            while (json.IndexOf('{') != -1)
            {
                string temp = json.Substring(0, json.IndexOf('}') + 1);

                json = json.Substring(json.IndexOf('}') + 1);

                contact = JsonSerializer.Deserialize<Contact>(temp, options);

               project.ContactsList.Add(contact);
               
            }
            return project;
        }
      public static void SaveContactListToFile(Project project)
        {
            for (int i = 0; i < project.ContactsList.Count; i++)
            {
                string temp = JsonSerializer.Serialize(project.ContactsList[i],options);
                File.AppendAllText(ContactsApp.My_Constants.WholePath,temp);
            }



        }



        

       public static Contact SearchForContact(string text)
        {
            int index = json2.IndexOf(text);
            Contact contact1 = new Contact();

            if (index != -1)
            {

                int pos_left = json2.Substring(0, index).LastIndexOf('{');

                int pos_right = json2.Substring(pos_left, json2.Length - pos_left).IndexOf('}');

                string temp1 = json2.Substring(pos_left, pos_right + 1);

                
                contact1 = JsonSerializer.Deserialize<Contact>(temp1, options);

                
            }
            return contact1;
        }


    }

    
    
    public static class My_Constants
    {
        public static string DocFolder = Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments,
            Environment.SpecialFolderOption.Create);
        public  const string MyPath = "ContactsApp.notes";
        public static string WholePath = Path.Combine(DocFolder,MyPath);
    }
}
