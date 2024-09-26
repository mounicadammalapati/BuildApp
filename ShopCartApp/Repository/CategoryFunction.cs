using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ShopCartApp.Repository
{
    public class CategoryFunction
    {
        private readonly ILogger<CategoryFunction> _logger;
        private ICategoryRepo _categoryRepo;

        public CategoryFunction(ILogger<CategoryFunction> logger, ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
            _logger = logger;
        }

        [Function("GetCategories")]
        public async Task<HttpResponseData> GetCategories([HttpTrigger(AuthorizationLevel.Anonymous, "get",Route ="GetCategories")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
            var result =  _categoryRepo.GetCategories();
            await response.WriteAsJsonAsync(result);
            return (response);
            //return response;
           // return new OkObjectResult(result);
        }
    }
}
