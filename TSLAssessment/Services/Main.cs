using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
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

            //tuples

            try
            {
                var tuple = (Name: "abc", Gender: "M", Age: 20);
                Console.WriteLine(tuple.Name);
                Console.WriteLine(tuple.Gender);
                Console.WriteLine(tuple.Age);
            }

            catch (FormatException e)
            {
                _logService.LogError(e.GetType().ToString(), e.Message);
            }
            catch (OverflowException e)
            {
                _logService.LogError(e.GetType().ToString(), e.Message);
            }
            catch (ArgumentNullException e)
            {
                _logService.LogError(e.GetType().ToString(), e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.Run(async context => await context.Response.WriteAsync("Middware write."));
        }
    }
}
