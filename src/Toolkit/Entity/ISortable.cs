namespace Sharemee.Toolkit.Entity;

/// <summary>
/// Sortable type: <see cref="int"/>
/// </summary>
public interface ISortable
{
    /// <summary>
    /// Sort
    /// </summary>
    int Sort { get; set; }
}

/// <summary>
/// Sortable type: <see cref="TType"/>
/// </summary>
public interface ISortable<TType> where TType : IEquatable<TType>
{
    /// <summary>
    /// Sort
    /// </summary>
    TType Sort { get; set; }
}
