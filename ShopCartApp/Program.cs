using AutoMapper;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ShopCartApp.Entities;
using ShopCartApp.Mappings;
using ShopCartApp.Repository;
using System.Reflection;

public class Program
{
    const string DevEnvValue = "Development";
    const string DBPath = "./DemoDB.db";

    const string Azure_DBPath = "D:/home/DemoDB.DB";

    static void CopyDb()
    {
        File.Copy(DBPath, Azure_DBPath);
        File.SetAttributes(Azure_DBPath, FileAttributes.Normal);

    }

    public static void Main()
    {
        bool isDevEnv = Environment.GetEnvironmentVariable("AZURE_FUNCTIONS_ENVIRONMENT") == DevEnvValue ? true : false;

        if (!isDevEnv && !File.Exists(Azure_DBPath))
        {
            CopyDb();
        }
        var host = new HostBuilder()
            .ConfigureFunctionsWebApplication()
            .ConfigureServices(services =>
            {
                services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)));
                services.AddApplicationInsightsTelemetryWorkerService();
                services.ConfigureFunctionsApplicationInsights();
                services.AddLogging();
                services.AddScoped<ICategoryRepo,CategoryRepo>();
                services.AddScoped<IProductRepo, ProductRepo>();
               
                //services.AddScoped<ILogger, Logger>();
                services.AddSingleton<ILoggerFactory,LoggerFactory>();
                services.AddScoped<DemoDbContext>(svc =>
                {
                    var options = new DbContextOptionsBuilder<DemoDbContext>().UseSqlite($"Data Source={(isDevEnv ? DBPath : Azure_DBPath)};");
                    return new DemoDbContext(options.Options);
                });
            })
            .Build();

        host.Run();
    }
}
