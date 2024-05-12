using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Sharemee.Toolkit.Authentication.JwtBearer;

/// <summary>
/// 用于在 <see cref="IServiceCollection"/> 中设置 JWT 服务的扩展方法
/// </summary>
public static class ServiceCollectionExtension
{
    /// <summary>
    /// 注册 JWT 服务及相关配置
    /// </summary>
    /// <param name="services"></param>
    /// <param name="tokenValidationParameters"></param>
    /// <returns></returns>
    public static IServiceCollection AddJwt(this IServiceCollection services, TokenValidationParameters tokenValidationParameters)
    {
        // 注入 JwtOptions
        services.AddOptions<JwtOptions>().BindConfiguration(nameof(JwtOptions));

        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = tokenValidationParameters;
            });

        services.AddScoped<IJwtBearerService, JwtBearerService>();
        return services;
    }
}
