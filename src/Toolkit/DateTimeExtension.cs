using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sharemee.Toolkit;

public static class DateTimeExtension
{
    public const long UniversalTimeTicks = 621355968000000000;
    public static DateTime UniversalStartTime = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

    //[MethodImpl(MethodImplOptions.AggressiveInlining)]
    //public static long Timestamp(this DateTime dateTime)
    //{
    //    return (dateTime.ToUniversalTime().Ticks - UniversalTimeTicks) / 10000000;
    //}

    public static long Timestamp(this DateTime dateTime)
    {
        return (long)(dateTime.ToUniversalTime() - UniversalStartTime).TotalSeconds;
    }
}
