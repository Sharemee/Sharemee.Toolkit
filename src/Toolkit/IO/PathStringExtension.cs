using System;
using System.Collections.Generic;
using System.Text;

namespace Sharemee.Toolkit.IO;

/// <summary>
/// 路径字符串扩展类
/// </summary>
public static class PathStringExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <param name="path2"></param>
    /// <returns></returns>
    public static string PathCombin(this string path, string path2)
    {
        return Path.Combine(path, path2);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>
    public static string EnsureTrailingSlash(string path)
    {
#if NETSTANDARD2_0
        if (!string.IsNullOrEmpty(path) && path[path.Length - 1] != Path.DirectorySeparatorChar)
#else
        if (!string.IsNullOrEmpty(path) && path[^1] != Path.DirectorySeparatorChar)
#endif
        {
            return path + Path.DirectorySeparatorChar;
        }
        return path;
    }
}
