using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLAssessment.Interfaces;

namespace TSLAssessment.Services
{
    public class LogService : ILogService
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string errorType, string message)
        {
            Console.WriteLine($"{errorType} : {message}");
        }
    }
}
