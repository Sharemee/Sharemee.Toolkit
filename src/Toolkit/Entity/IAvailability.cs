namespace Sharemee.Toolkit.Entity;

/// <summary>
/// 
/// </summary>
public interface IAvailability
{
    /// <summary>
    /// 可用性
    /// </summary>
    /// <remarks>True: 可用, 否则不可用</remarks>
    bool Availability { get; set; }
}
