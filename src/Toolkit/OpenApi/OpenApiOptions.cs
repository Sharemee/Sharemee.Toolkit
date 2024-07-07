using Microsoft.OpenApi.Models;

namespace Sharemee.Toolkit.OpenApi;

/// <summary>
/// 接口信息配置
/// </summary>
public class OpenApiOptions
{
    /// <summary>
    /// A short description of the application.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The version of the OpenAPI document.
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// 接口分组列表
    /// </summary>
    public List<OpenApiGroup> OpenApiGroups { get; set; } = [];
}

/// <summary>
/// 接口分组信息
/// </summary>
public class OpenApiGroup
{
    /// <summary>
    /// REQUIRED. The title of the application.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// A short description of the application.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The version of the OpenAPI document.
    /// </summary>
    public string? Version { get; set; }

    /// <summary>
    /// 是否是默认分组
    /// </summary>
    public bool IsDefault { get; set; }

    public OpenApiInfo GetOpenApiInfo(OpenApiOptions openApiOptions)
    {
        return new OpenApiInfo()
        {
            Title = Name,
            Description = Description ?? openApiOptions.Description ?? string.Empty,
            Version = Version ?? openApiOptions.Version ?? "1.0.0",
        };
    }
}
