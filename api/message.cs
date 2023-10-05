using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public static class message
    {
        private readonly ILogger _logger;

        public message(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<message>();
        }

        [FunctionName("message")]
        public static async Task<string> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            System.Threading.Thread.Sleep(20000);

            _logger.LogInformation("C# HTTP trigger function processed a request.");

            return "Complete";
        }
    }
}
