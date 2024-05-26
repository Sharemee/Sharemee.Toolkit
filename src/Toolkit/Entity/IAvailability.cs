namespace Sharemee.Toolkit.Entity;

/// <summary>
/// 可用性标识字段接口
/// </summary>
public interface IAvailability
{
    /// <summary>
    /// 可用性
    /// </summary>
    /// <remarks>True: 可用, 否则不可用</remarks>
    bool Availability { get; set; }
}
