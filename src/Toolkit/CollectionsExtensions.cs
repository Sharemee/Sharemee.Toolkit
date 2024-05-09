using System.Collections.ObjectModel;

namespace Sharemee.Toolkit;

/// <summary>
/// 
/// </summary>
public static class CollectionsExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="colleciton"></param>
    /// <param name="enumerable"></param>
    public static void AddRange<T>(this Collection<T> colleciton, IEnumerable<T> enumerable)
    {
        foreach (T item in enumerable)
        {
            colleciton.Add(item);
        }
    }
}
