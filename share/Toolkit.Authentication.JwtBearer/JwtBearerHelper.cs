using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;

namespace Sharemee.Toolkit.Authentication.JwtBearer;

internal sealed class JwtBearerHelper
{
    /// <summary>
    /// 生成 JWT 负载
    /// </summary>
    /// <param name="jwtOptions">JWP 配置</param>
    /// <param name="claims">JWT 声明集合</param>
    /// <param name="expiredTime">Token 过期时间, 单位: 分钟</param>
    /// <returns></returns>
    internal static string GenerateJwtPayload(JwtOptions jwtOptions, IEnumerable<Claim> claims, double? expiredTime = null)
    {
        // 确定过期时间
        DateTime? realExpiredTime = null;
        if (jwtOptions.RequireExpirationTime)
        {
            // 过期时间采用优先级: 当前函数参数 > JwtOptions配置 > 默认值(15分钟)
            realExpiredTime = DateTime.UtcNow.AddMinutes(expiredTime ?? jwtOptions.ExpiredTime ?? 15);
        }

        // 生成 JWT 负载
        JwtPayload jwtPayload = new(
            jwtOptions.ValidIssuer,  // 发行人
            jwtOptions.ValidAudience,// 受众
            claims: claims,          // 自定义负载
            notBefore: null,         // Token 在此时间之前不能生效
            realExpiredTime          // Token 过期时间
            );
        return jwtPayload.SerializeToJson();
    }

    internal static string GenerateToken(string payload, SigningCredentials? signingCredentials)
    {
        var tokenHandler = new JsonWebTokenHandler();
        return signingCredentials is null
            ? tokenHandler.CreateToken(payload)
            : tokenHandler.CreateToken(payload, signingCredentials);
    }
}
