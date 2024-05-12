using Microsoft.Extensions.DependencyInjection;
using Sharemee.ToolKit.Repository.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddGenericsRepository(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
