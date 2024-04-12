using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PatternsConsole
{
    public class Worker
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<Worker> _logger;
        public void Run()
        {
           _logger.LogInformation("Hello world");
            var connectionString = _configuration.GetSection("ConnectionString")["TestConnection"];
            _logger.LogInformation($"Connection string {connectionString}");
        }
        public Worker(IConfiguration configuration, ILogger<Worker> logger)
        { 
            _configuration = configuration;
            _logger = logger;
        }
    }
}