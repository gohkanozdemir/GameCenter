using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class FileLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Ilgili dosyaya loglandi.");
        }
    }
}
