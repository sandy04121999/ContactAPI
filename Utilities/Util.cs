using ContactsManagementAPI.Models;
using System.Text.Json;

namespace ContactsManagementAPI.Utilities
{
    public static class Util
    {
        private static string _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Json", "ContactsData.json");
        public static List<Contact> ReadFromFile()
        {
            string readJsonData = System.IO.File.ReadAllText(_filePath);
            List<Contact> contacts = JsonSerializer.Deserialize<List<Contact>>(readJsonData);

            return contacts;
        }

        public static bool WriteFromFile(List<Contact> contacts)
        {
            bool isWrite = false;
            try
            {
                string writeJsonData = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
                System.IO.File.WriteAllText(_filePath, writeJsonData);
                isWrite = true;
            }
            catch (Exception ex)
            {
                isWrite = false;
            }
            return isWrite;
        }
    }
}
