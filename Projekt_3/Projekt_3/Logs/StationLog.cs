using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Projekt_3
{
    internal class StationLog : IDisposable
    {
        private StreamWriter LogStream { get; set; }
        public StationLog(string filePath)
        {
            try
            {
                LogStream = new StreamWriter(filePath, append: true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при відкритті файлу для логування: {ex.Message}");
                throw;
            }
        }

        public void WriteLog(string message)
        {
            if(LogStream == null)
            {
                Console.WriteLine("Логування недоступне. Файл не відкритий.");
                return;
            }
            string logEntry = $"{DateTime.Now}: {message}";
            LogStream.WriteLine(logEntry);
            LogStream.Flush();
        }
        public void Dispose()
        {
            LogStream?.Dispose();
        }
    }
}
