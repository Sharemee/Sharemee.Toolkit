namespace Sharemee.Toolkit.Authentication.JwtBearer;

/// <summary>
/// JWT Options
/// </summary>
public class JwtOptions
{
    /// <summary>
    /// 有效发行人
    /// </summary>
    /// <remarks>Default value: <see langword="null"/></remarks>
    public string? ValidIssuer { get; set; }

    /// <summary>
    /// 是否验证发行人
    /// </summary>
    /// <remarks>Default value: <see langword="true"/></remarks>
    public bool ValidateIssuer { get; set; } = true;

    /// <summary>
    /// 发行人签名密钥
    /// </summary>
    public string IssuerSigningKey { get; set; } = null!;

    /// <summary>
    /// 是否验证发行人签名密钥
    /// </summary>
    /// <remarks>Default value: <see langword="false"/></remarks>
    public bool ValidateIssuerSigningKey { get; set; } = false;

    /// <summary>
    /// 有效受众
    /// </summary>
    /// <remarks>Default value: <see langword="null"/></remarks>
    public string? ValidAudience { get; set; }

    /// <summary>
    /// 是否验证受众
    /// </summary>
    /// <remarks>Default value: <see langword="true"/></remarks>
    public bool ValidateAudience { get; set; } = true;

    /// <summary>
    /// 是否验证 Token 生命周期
    /// </summary>
    /// <remarks>Default value: <see langword="true"/></remarks>
    public bool ValidateLifetime { get; set; } = true;

    /// <summary>
    /// 时钟脉冲相位差
    /// </summary>
    /// <remarks>Default value: 300 seconds</remarks>
    public long ClockSkew { get; set; } = 300L;

    /// <summary>
    /// Token 是否必须具有过期(expiration)值
    /// </summary>
    /// <remarks>Default value: <see langword="true"/></remarks>
    public bool RequireExpirationTime { get; set; } = true;

    /// <summary>
    /// Token 过期时间
    /// </summary>
    public long? ExpiredTime { get; set; }

    ///// <summary>
    ///// Token签名算法
    ///// </summary>
    ///// <remarks>Default value: <see cref="SecurityAlgorithms.HmacSha256"/></remarks>
    //public string Algorithm { get; set; } = SecurityAlgorithms.HmacSha256;
}
