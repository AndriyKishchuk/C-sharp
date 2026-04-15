namespace Projekt_10
{
    public static class TextConfigurationExtensions
    {
        public static IConfigurationBuilder AddTextFile(this IConfigurationBuilder builder, string filePath)
        {
            return builder.Add(new TextConfigurationSource(filePath));
        }
    }
}
