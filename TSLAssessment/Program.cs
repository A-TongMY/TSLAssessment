using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TSLAssessment.Interfaces;
using TSLAssessment.Services;

using IHost host = CreateHostBuilder(args).Build();

using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;


try
{
    services.GetRequiredService<Main>().Run(args);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

IHostBuilder CreateHostBuilder(string[] strings)
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((_, services) =>
        {
            services.AddSingleton<ILogService, LogService>();
            services.AddSingleton<Main>();
        });
}
