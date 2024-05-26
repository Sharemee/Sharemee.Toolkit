using Microsoft.AspNetCore.Mvc;

namespace Sharemee.Toolkit.Http;

/// <summary>
/// 将 <see cref="HttpResult"/> 对象包装成 <see cref="ActionResult"/> 用于返回 Http 应答
/// </summary>
public static class HttpResultExtensions
{
    /// <summary>
    /// 将 <see cref="HttpResult"/> 对象包装成 <see cref="OkObjectResult"/>
    /// </summary>
    /// <param name="result"><see cref="HttpResult"/></param>
    /// <returns></returns>
    public static OkObjectResult OkResult(this HttpResult result)
    {
        return new OkObjectResult(result);
    }
}
