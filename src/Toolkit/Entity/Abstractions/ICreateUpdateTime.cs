namespace Sharemee.Toolkit.Entity.Abstractions;

/// <summary>
/// 创建时间属性接口
/// </summary>
public interface ICreateTime
{
    /// <summary>
    /// 创建时间
    /// </summary>
    DateTime CreateTime { get; set; }
}

/// <summary>
/// 更新时间属性接口
/// </summary>
public interface IUpdateTime
{
    /// <summary>
    /// 更新时间
    /// </summary>
    DateTime? UpdateTime { get; set; }
}

/// <summary>
/// 创建与更新时间属性接口
/// </summary>
public interface ICreateUpdateTime : ICreateTime, IUpdateTime
{
}