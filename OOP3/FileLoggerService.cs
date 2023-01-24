using System;

namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("İşlem dosyaya kayıt edildi.");
        }
    }
}
