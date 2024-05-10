namespace Sharemee.Toolkit.Http;

/// <summary>
/// Http 响应数据模型
/// </summary>
public class HttpResult
{
    /// <summary>
    /// 服务端返回的请求处理状态
    /// </summary>
    /// <remarks>
    /// 值对应的请求状态可以自定义, 不限于以下列出的一种示例:
    /// <list type="bullet">
    ///     <item>0: 请求处理成功</item>
    ///     <item>1: 请求处理失败</item>
    /// </list>
    /// </remarks>
    public int Code { get; set; }

    /// <summary>
    /// 服务端返回的消息
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// 服务端返回的数据
    /// </summary>
    public object? Data { get; set; }

    /// <summary>
    /// 时间戳
    /// </summary>
    public long Timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
}

/// <inheritdoc/>
public class HttpResult<T> : HttpResult
{
    /// <summary>
    /// 服务端返回的数据
    /// </summary>
    public new T? Data { get; set; }
}
