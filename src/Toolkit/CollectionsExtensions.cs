using System.Collections.ObjectModel;

namespace Sharemee.Toolkit;

public static class CollectionsExtensions
{
    public static void AddRange<T>(this Collection<T> colleciton, IEnumerable<T> enumerable)
    {
        foreach (T item in enumerable)
        {
            colleciton.Add(item);
        }
    }
}
