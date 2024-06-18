namespace Sharemee.Toolkit.Entity.Abstractions;

/// <summary>
/// Primary key type: <see cref="int"/>
/// </summary>
public interface IPrimaryKey
{

}

/// <summary>
/// Primary key
/// </summary>
/// <typeparam name="TType"></typeparam>
public interface IPrimaryKey<TType> : IPrimaryKey where TType : IEquatable<TType>
{
    /// <summary>
    /// Primary key
    /// </summary>
    TType Id { get; set; }
}
