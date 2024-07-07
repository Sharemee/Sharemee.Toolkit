namespace Sharemee.Toolkit.Entity.Abstractions;

/// <summary>
/// 软删除属性接口
/// </summary>
public interface ISoftDelete
{
    /// <summary>
    /// 是否已删除
    /// </summary>
    /// <remarks>0: 未删除; 1: 已删除</remarks>
    bool IsDeleted { get; set; }
}
