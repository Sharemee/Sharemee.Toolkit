using System.Security.Claims;

namespace Sharemee.Toolkit.Authentication.JwtBearer;

/// <summary>
/// JWT Bearer 服务接口
/// </summary>
public interface IJwtBearerService
{
    /// <summary>
    /// 生成 Token
    /// </summary>
    /// <param name="payload">Token 负载</param>
    /// <param name="expiredTime">Token 过期时间, 单位: 分钟</param>
    /// <returns></returns>
    string GenerateToken(IDictionary<string, object?> payload, double? expiredTime = null);

    /// <summary>
    /// 生成 Token
    /// </summary>
    /// <param name="claims">JWT 声明集合</param>
    /// <param name="expiredTime">Token 过期时间, 单位: 分钟</param>
    /// <returns></returns>
    string GenerateToken(IEnumerable<Claim> claims, double? expiredTime = null);
}
