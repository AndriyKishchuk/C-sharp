namespace Projekt_10
{
    public class TextConfigurationSource : IConfigurationSource
    {
        public string? FilePath { get; set; }
        public TextConfigurationSource(string filePath)
        {
            FilePath = filePath;
        }
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            string? path = builder.GetFileProvider()?.GetFileInfo(FilePath ?? string.Empty).PhysicalPath;
            return new TextConfigurationProvider(path ?? FilePath ?? string.Empty);
        }
    }
}
