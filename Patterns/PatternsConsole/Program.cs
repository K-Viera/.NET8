using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PatternsConsole;
using Microsoft.Extensions.Configuration;

IHost host = CreateHostBuilder().Build();
var worker = ActivatorUtilities.CreateInstance<Worker>(host.Services);
worker.Run();


static IHostBuilder CreateHostBuilder() =>
    Host.CreateDefaultBuilder()
    .ConfigureAppConfiguration((context, configuration) =>
    {
        configuration.Sources.Clear();
        configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
    });