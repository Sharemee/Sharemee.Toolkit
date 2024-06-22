using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharemee.Toolkit.Http
{
    public partial class HttpResult
    {
        /// <summary>
        /// Success
        /// </summary>
        /// <returns></returns>
        public static HttpResult Success()
        {
            return Build(DefaultSuccessCode, true, DefaultSuccessMessage);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="code">代码</param>
        /// <returns></returns>
        public static HttpResult Success(int code)
        {
            return Build(code, true, DefaultSuccessMessage);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static HttpResult Success(string message)
        {
            return Build(DefaultSuccessCode, true, message);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="data">数据</param>
        /// <returns></returns>
        /// <remarks>调用该函数最好使用参数名称调用, 否则当数据是字符串时可能不会正确调用此函数</remarks>
        public static HttpResult Success<T>(T data)
        {
            return Build(DefaultSuccessCode, true, DefaultSuccessMessage, data);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="code">代码</param>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static HttpResult Success(int code, string message)
        {
            return Build(code, true, message);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static HttpResult Success(string message, object data)
        {
            return Build(DefaultSuccessCode, true, message, data);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="code">代码</param>
        /// <param name="message">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static HttpResult Success(int code, string message, object data)
        {
            return Build(code, true, message, data);
        }
    }
}
