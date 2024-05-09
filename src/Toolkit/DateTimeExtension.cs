namespace Sharemee.Toolkit;

/// <summary>
/// <see cref="DateTime"/> extension methods
/// </summary>
public static class DateTimeExtension
{
    /// <summary>
    /// 
    /// </summary>
    public const long UniversalTimeTicks = 621355968000000000;

    /// <summary>
    /// 
    /// </summary>
    public static readonly DateTime UniversalStartTime = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //public static long Timestamp(this DateTime dateTime)
    //{
    //    return (dateTime.ToUniversalTime().Ticks - UniversalTimeTicks) / 10000000;
    //}
    
    /// <summary>
    /// Get timestamp
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns></returns>
    public static long Timestamp(this DateTime dateTime)
    {
        return (long)(dateTime.ToUniversalTime() - UniversalStartTime).TotalSeconds;
    }
}
