namespace Sharemee.Toolkit;

/// <summary>
/// <see cref="DateTime"/> 类型扩展.
/// </summary>
/// <remarks>便捷地获取时间戳</remarks>
public static class DateTimeExtension
{
    /// <summary>
    /// 世界时间起始时间刻度(Ticks)
    /// </summary>
    /// <remarks>1毫秒 = 10000 时间刻度(Ticks)</remarks>
    public const long UniversalTimeTicks = 621355968000000000;

    /// <summary>
    /// 世界时间起始点
    /// </summary>
    public static readonly DateTime UniversalStartTime = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //public static long Timestamp(this DateTime dateTime)
    //{
    //    return (dateTime.ToUniversalTime().Ticks - UniversalTimeTicks) / 10000000;
    //}

    /// <summary>
    /// Unix 标准时间戳
    /// </summary>
    /// <param name="dateTime">时间</param>
    /// <returns></returns>
    /// <remarks>
    /// 由于 <see cref="TimeSpan.TotalSeconds"/> 是 <see langword="double"/> 类型, 因此导致计算结果小数部分.
    /// 但强制转换为 <see langword="long"/> 类型后, 抛弃了小数部分, 结果依然是正确的.
    /// </remarks>
    public static long Timestamp(this DateTime dateTime)
    {
        return (long)(dateTime.ToUniversalTime() - UniversalStartTime).TotalSeconds;
    }

    /// <summary>
    /// 毫秒级时间戳
    /// </summary>
    /// <param name="dateTime">时间</param>
    /// <returns></returns>
    /// <remarks>
    /// 由于 <see cref="TimeSpan.TotalSeconds"/> 是 <see langword="double"/> 类型, 因此导致计算结果小数部分.
    /// 但强制转换为 <see langword="long"/> 类型后, 抛弃了小数部分, 结果依然是正确的.
    /// </remarks>
    public static long TimestampInMs(this DateTime dateTime)
    {
        return (long)(dateTime.ToUniversalTime() - UniversalStartTime).TotalMilliseconds;
    }
}
