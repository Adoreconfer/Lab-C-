using Lab5.Task;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab5.FileLab
{
    internal class JsonContactRepository
    {
        private readonly string _filePath;
        public JsonContactRepository(string filePath)
        {
            _filePath = filePath;
        }

        public void Save(List<Contact> contacts)
        {
            JsonSerializerOptions options = new JsonSerializerOptions() { 
                WriteIndented = true, // plik z wcięciami
            };

            string json = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(_filePath, json);
        }

        public List<Contact> GetContacts()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Contact>();
            }

            string json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json)) { 
                return new List<Contact>();
            }

            List<Contact> contacts = JsonSerializer.Deserialize<List<Contact>>(json);

            return contacts ?? new List<Contact>();

            //if(contacts == null)
            //    return new List<Contact>();
            //return contacts;
        }
    }
}
