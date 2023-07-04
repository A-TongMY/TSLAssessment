using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSLAssessment.Interfaces;

namespace TSLAssessment.Services
{
    public class Main
    {
        private readonly ILogService _logService;
        
        public Main(ILogService logService)
        {
            _logService = logService;
        }

        public void Run(string[] args)
        {
            _logService.LogMessage("Injected in Main run, logging.");
        }
    }
}
