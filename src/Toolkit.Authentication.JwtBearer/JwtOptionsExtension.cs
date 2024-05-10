using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Sharemee.Toolkit.Authentication.JwtBearer;

/// <summary>
/// <see cref="JwtOptions"/> extension
/// </summary>
public static class JwtOptionsExtension
{
    /// <summary>
    /// Bind user <see cref="JwtOptions"/> to <see cref="TokenValidationParameters"/>
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    public static TokenValidationParameters BindTokenValidation(this JwtOptions options)
    {
        ThrowHelper.ThrowIfNull(options);
        ThrowHelper.ThrowIfNullOrEmpty(options.IssuerSigningKey);

        return new TokenValidationParameters()
        {
            // 设置有效发行人
            ValidIssuer = options.ValidIssuer,
            // 设置是否验证发行人
            ValidateIssuer = options.ValidateIssuer,

            // 设置发行人签名密钥
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.IssuerSigningKey)),
            // 设置是否验证发行人密钥
            ValidateIssuerSigningKey = options.ValidateIssuerSigningKey,

            // 设置有效受众
            ValidAudience = options.ValidAudience,
            // 设置是否验证受众
            ValidateAudience = options.ValidateAudience,

            // 设置是否验证 Token 生命周期
            ValidateLifetime = options.ValidateLifetime,

            // 设置时钟脉冲相位差
            ClockSkew = TimeSpan.FromSeconds(options.ClockSkew),

            // 设置 Token 是否必须具有过期时间
            RequireExpirationTime = options.RequireExpirationTime,
        };
    }
}
