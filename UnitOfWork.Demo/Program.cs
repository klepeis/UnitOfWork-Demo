using Autofac;
using Autofac.Extensions.DependencyInjection;
using UnitOfWork.Demo.Repositories;
using UnitOfWork.Demo.Services;

namespace UnitOfWork.Demo;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //1. Add services to the container.
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IWidgetRepository, WidgetRepository>();
        builder.Services.AddScoped<IActivityTrackingRepository, ActivityTrackingRepository>();
        builder.Services.AddScoped<IWidgetCommandService, WidgetCommandService>();

        builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(builder =>
            {
                //2. Register Decorator
                builder.RegisterDecorator<WidgetRepositoryActivityTracking, IWidgetRepository>();
            });

        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

