using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using PatternsConsole;

IHost host = CreateHostBuilder().Build();
var worker = ActivatorUtilities.CreateInstance<Worker>(host.Services);
worker.Run();


static IHostBuilder CreateHostBuilder() =>
    Host.CreateDefaultBuilder();