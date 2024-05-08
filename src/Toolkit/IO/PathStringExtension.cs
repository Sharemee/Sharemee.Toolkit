using System;
using System.Collections.Generic;
using System.Text;

namespace Sharemee.Toolkit.IO;

public static class PathStringExtension
{
    public static string PathCombin(this string path, string path2)
    {
        return Path.Combine(path, path2);
    }

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
