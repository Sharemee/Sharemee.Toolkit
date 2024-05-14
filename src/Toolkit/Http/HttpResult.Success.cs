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
            return Build(0, true, "Success");
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="code">代码</param>
        /// <returns></returns>
        public static HttpResult Success(int code)
        {
            return Build(code, true, "Success");
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static HttpResult Success(string message)
        {
            return Build(0, true, message);
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
        /// <param name="code">代码</param>
        /// <param name="message">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static HttpResult Success(int code, string message, object data)
        {
            return Build(code, true, message, data);
        }

        /// <summary>
        /// Success
        /// </summary>
        /// <param name="message">消息</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static HttpResult Success(string message, object data)
        {
            return Build(0, true, message, data);
        }
    }
}
