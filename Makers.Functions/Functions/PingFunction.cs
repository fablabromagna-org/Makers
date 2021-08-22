using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;

namespace Makers.Functions.Functions
{
    public static class PingFunction
    {
        [FunctionName(nameof(PingFunction))]
        public static Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
            HttpRequest req)
        {
            return Task.FromResult<IActionResult>(new OkResult());
        }
    }
}