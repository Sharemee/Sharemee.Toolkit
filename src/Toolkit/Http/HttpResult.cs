namespace Sharemee.Toolkit.Http;

/// <summary>
/// Http 响应数据模型
/// </summary>
public partial class HttpResult
{
    #region Properties

    /// <summary>
    /// 代码
    /// </summary>
    /// <remarks>默认: 0</remarks>
    public int Code { get; set; } = 0;

    /// <summary>
    /// 状态
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    ///   <item><see langword="true"/>: 表示成功</item>
    ///   <item><see langword="false"/>: 表示失败</item>
    ///   <item>默认: <see langword="false"/></item>
    /// </list>
    /// </remarks>
    public bool Status { get; set; } = false;

    /// <summary>
    /// 消息
    /// </summary>
    /// <remarks>默认: <see cref="string.Empty"/></remarks>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// 数据
    /// </summary>
    /// <remarks>默认: <see langword="null"/></remarks>
    public virtual object? Data { get; set; } = null;

    /// <summary>
    /// 时间戳
    /// </summary>
    public long Timestamp { get; set; } = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

    #endregion

    #region Constructor

    /// <summary>
    /// 构造函数
    /// </summary>
    public HttpResult() { }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="code">代码</param>
    /// <param name="status">状态</param>
    /// <param name="message">消息</param>
    /// <param name="data">数据</param>
    /// <param name="timestamp">时间戳</param>
    public HttpResult(int code, bool status, string message, object? data = null, long? timestamp = null)
    {
        Code = code;
        Status = status;
        Message = message;
        Data = data;
        Timestamp = timestamp ?? DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    }

    #endregion

    /// <summary>
    /// 静态构建 <see cref="HttpResult"/> 实例的方法
    /// </summary>
    /// <param name="code">代码</param>
    /// <param name="status">状态</param>
    /// <param name="message">消息</param>
    /// <param name="data">数据</param>
    /// <param name="timestamp">时间戳</param>
    /// <returns></returns>
    public static HttpResult Build(int code, bool status, string message, object? data = null, long? timestamp = null)
    {
        return new HttpResult(code, status, message, data, timestamp);
    }
}
