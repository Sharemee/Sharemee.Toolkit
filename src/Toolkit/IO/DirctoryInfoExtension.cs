namespace Sharemee.Toolkit.IO;

/// <summary>
/// 
/// </summary>
public static class DirctoryInfoExtension
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dirctoryInfo"></param>
    /// <param name="paths"></param>
    /// <returns></returns>
    public static DirectoryInfo PathCombine(this DirectoryInfo dirctoryInfo, params string[] paths)
    {
        return PathCombine(dirctoryInfo, false, paths);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dirctoryInfo"></param>
    /// <param name="ensureExists"></param>
    /// <param name="paths"></param>
    /// <returns></returns>
    public static DirectoryInfo PathCombine(this DirectoryInfo dirctoryInfo, bool ensureExists = false, params string[] paths)
    {
        if (paths is null || paths.Length == 0)
        {
            return EnsureDirectoryExists(dirctoryInfo, ensureExists);
        }

        if (paths.Length == 1)
        {
            return EnsureDirectoryExists(Path.Combine(dirctoryInfo.FullName, paths[0]), ensureExists);
        }

        return EnsureDirectoryExists(Path.Combine(dirctoryInfo.FullName, Path.Combine(paths)), ensureExists);
    }

    /// <summary>
    /// Ensure directory exists
    /// </summary>
    /// <param name="dirctoryInfo"></param>
    /// <returns>If directory already exists then <see langword="false"/>, if create new return <see langword="true"/></returns>
    public static bool EnsureExists(this DirectoryInfo dirctoryInfo)
    {
        // TODO: check root directory exists, otherwise report error.
        if (dirctoryInfo.Exists) return false;

        dirctoryInfo.Create();
        return true;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dirctoryPath"></param>
    /// <param name="ensureExists"></param>
    /// <returns></returns>
    private static DirectoryInfo EnsureDirectoryExists(string dirctoryPath, bool ensureExists)
    {
        DirectoryInfo di = new(dirctoryPath);
        return EnsureDirectoryExists(di, ensureExists);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dirctoryInfo"></param>
    /// <param name="ensureExists"></param>
    /// <returns></returns>
    /// <exception cref="IOException"></exception>
    private static DirectoryInfo EnsureDirectoryExists(DirectoryInfo dirctoryInfo, bool ensureExists)
    {
        if (ensureExists && !dirctoryInfo.Exists)
        {
            if (dirctoryInfo.Root.Exists)
            {
                dirctoryInfo.Create();
            }
            else
            {
                throw new IOException($"Root \"{dirctoryInfo.Root}\" not exists");
            }
        }
        return dirctoryInfo;
    }

    // TODO:
    //public static bool EnsureExisted(this DirectoryInfo directoryInfo)
    //{
    //    if(directoryInfo.Exists)
    //    {
    //        return true;
    //    }
    //    directoryInfo.Root
    //}
}
