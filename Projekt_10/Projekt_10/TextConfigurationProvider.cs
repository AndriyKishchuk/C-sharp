namespace Projekt_10
{
    public class TextConfigurationProvider : ConfigurationProvider
    {
        public string? FilePath { get; set; }
        public TextConfigurationProvider(string filePath)
        {
            FilePath = filePath;
        }

        public override void Load()
        {
            var data = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            using (var reader = new StreamReader(FilePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string key = line.Trim();
                    string? value = reader.ReadLine()?.Trim();
                    data.Add(key, value ?? string.Empty);
                }
            }
            Data = data;
        }
    }
}
