using Microsoft.Extensions.DependencyInjection;
using Sharemee.ToolKit.Repository.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework;

/// <summary>
/// 用于注册仓储的扩展
/// </summary>
public static class ServiceCollectionExtension
{
    /// <summary>
    /// 注册泛型仓储
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddGenericsRepository(this IServiceCollection services)
    {
        return services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}
