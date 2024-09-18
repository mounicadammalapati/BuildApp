using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using ShopCartApp.Entities;

namespace ShopCartApp
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        DemoDbContext _demoDbContext;
        public Function1(ILogger<Function1> logger, DemoDbContext demoDbContext)
        {
            _logger = logger;
            _demoDbContext = demoDbContext;
        }

        [Function("Function1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {

            var result = _demoDbContext.People.ToList();

            _logger.LogInformation("C# HTTP trigger function processed a request.");


            return new OkObjectResult(result);
        }
    }
}
