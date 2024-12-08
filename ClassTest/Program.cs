using ContactsApp;
namespace ClassTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneNumber phoneNumber = new PhoneNumber("79036101321");
            Console.WriteLine(phoneNumber.Phone_Number);

            Contact contact = new Contact();
            contact.LastName = "Иванов";
            contact.FirstName = "Иван";
            contact.Phone = phoneNumber.Phone_Number;
            contact.Birthday = "11.04.1957";
            contact.Email = "smmsmm11@mail.ru";
            contact.VkId = "1111111";
            Console.WriteLine(contact.LastName+ " " + contact.FirstName + " " + contact.Phone + " " + contact.Birthday + " " + 
                contact.Email + " " + contact.VkId);
        }
    }
}
