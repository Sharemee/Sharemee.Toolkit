namespace Sharemee.Toolkit.Entity.Abstractions;

/// <summary>
/// 可排序属性接口
/// </summary>
public interface ISortable
{
    /// <summary>
    /// 排序
    /// </summary>
    int Sort { get; set; }
}

/// <summary>
/// 可排序属性泛型接口
/// </summary>
public interface ISortable<TType> where TType : IEquatable<TType>
{
    /// <summary>
    /// 排序
    /// </summary>
    TType Sort { get; set; }
}
