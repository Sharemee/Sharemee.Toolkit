namespace Sharemee.Toolkit.Http;

public partial class HttpResult
{
    /// <summary>
    /// Fail
    /// </summary>
    /// <returns></returns>
    public static HttpResult Fail()
    {
        return Build(1, false, "Fail");
    }

    /// <summary>
    /// Fail
    /// </summary>
    /// <param name="code">代码</param>
    /// <returns></returns>
    public static HttpResult Fail(int code)
    {
        return Build(code, false, "Fail");
    }

    /// <summary>
    /// Fail
    /// </summary>
    /// <param name="message">消息</param>
    /// <returns></returns>
    public static HttpResult Fail(string message)
    {
        return Build(1, false, message);
    }

    /// <summary>
    /// Fail
    /// </summary>
    /// <param name="code">代码</param>
    /// <param name="message">消息</param>
    /// <param name="data">数据</param>
    /// <returns></returns>
    public static HttpResult Fail(int code, string message, object data)
    {
        return Build(code, false, message, data);
    }

    /// <summary>
    /// Fail
    /// </summary>
    /// <param name="message">消息</param>
    /// <param name="data">数据</param>
    /// <returns></returns>
    public static HttpResult Fail(string message, object data)
    {
        return Build(1, false, message, data);
    }
}
