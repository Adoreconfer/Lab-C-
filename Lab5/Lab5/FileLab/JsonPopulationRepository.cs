using Lab5.Task;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab5.FileLab
{
    internal class JsonPopulationRepository
    {
        private readonly string _filePath;
        public JsonPopulationRepository(string filePath)
        {
            _filePath = filePath;
        }
        public void Save(List<Population> populations)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true, 
            };

            string json = JsonSerializer.Serialize(populations, options);
            File.WriteAllText(_filePath, json);
        }

        public List<Population> GetPopulation()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Population>();
            }

            string json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                return new List<Population>();
            }

            List<Population> populations = JsonSerializer.Deserialize<List<Population>>(json);
            return populations ?? new List<Population>();
        }
    }
}
