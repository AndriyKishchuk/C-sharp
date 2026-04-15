namespace Projekt_10
{
    public class FileLogger : ILogger, IDisposable
    {
        string filepath;
        static object _lock = new object();

        public FileLogger(string path)
        {
            filepath = path;
        }

        public IDisposable BeginScope<TState>(TState state) => this;
        public void Dispose() { }

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string message = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logLevel}] {formatter(state, exception)}";
            lock (_lock)
            {
                File.AppendAllText(filepath, message + Environment.NewLine);
            }
        }
    }
}
