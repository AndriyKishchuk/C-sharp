namespace Projekt_10
{
    public static class FileLoggerExtensions
    {
        public static ILoggingBuilder AddFile(this ILoggingBuilder builder, string path)
        {
           return builder.AddProvider(new FileLoggerProvider(path));
        }
    }
}
