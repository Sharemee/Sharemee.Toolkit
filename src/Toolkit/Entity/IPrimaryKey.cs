namespace Sharemee.Toolkit.Entity;

/// <summary>
/// Primary key type: <see cref="int"/>
/// </summary>
public interface IPrimaryKey
{
    /// <summary>
    /// Primary key
    /// </summary>
    int Id { get; set; }
}

/// <summary>
/// Primary key type: <see cref="TType"/>
/// </summary>
/// <typeparam name="TType"></typeparam>
public interface IPrimaryKey<TType> where TType : IEquatable<TType>
{
    /// <summary>
    /// Primary key
    /// </summary>
    TType Id { get; set; }
}
