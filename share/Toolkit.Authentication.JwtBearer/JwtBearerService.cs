using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Sharemee.Toolkit.Authentication.JwtBearer;

/// <summary>
/// JWT Bearer 服务接口实现
/// </summary>
public class JwtBearerService : IJwtBearerService
{
    private readonly IOptions<JwtOptions> jwtOptions;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="options"><see cref="JwtOptions"/></param>
    public JwtBearerService(IOptions<JwtOptions> options)
    {
        this.jwtOptions = options;
    }

    /// <inheritdoc/>
    public string GenerateToken(IDictionary<string, object?> payloadSet, double? expiredTime = null)
    {
        // 将自定义负载包装成 JWT 声明集合
        IList<Claim> claims = [];
        if (payloadSet is not null)
        {
            foreach (KeyValuePair<string, object?> item in payloadSet)
            {
                claims.Add(new Claim(item.Key, item.Value?.ToString() ?? string.Empty, null));
            }
        }
        
        return GenerateToken(claims, expiredTime);
    }

    /// <inheritdoc/>
    public string GenerateToken(IEnumerable<Claim> claims, double? expiredTime = null)
    {
        JwtOptions jwt = jwtOptions.Value;

        // 生成 Token payload json
        string payload = JwtBearerHelper.GenerateJwtPayload(jwtOptions.Value, claims);

        // 生成 Credentials
        SigningCredentials? signingCredentials = null;
        if (!string.IsNullOrWhiteSpace(jwt.IssuerSigningKey))
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.IssuerSigningKey));
            signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        }

        return JwtBearerHelper.GenerateToken(payload, signingCredentials);
    }

}
