using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSLAssessment.Interfaces
{
    public interface ILogService
    {
        public void LogMessage(string message);
        public void LogError(string errorType, string message);
    }
}
