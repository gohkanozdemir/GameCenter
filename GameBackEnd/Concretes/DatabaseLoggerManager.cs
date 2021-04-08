using GameBackEnd.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackEnd.Concretes
{
    public class DatabaseLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Ilgili veritabanina loglandi.");
        }
    }
}
