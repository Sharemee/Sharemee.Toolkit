using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Sharemee.Toolkit;

/// <summary>
/// Throw exception helper
/// </summary>
public static class ThrowHelper
{
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if <paramref name="argument"/> is null.
    /// </summary>
    public static void ThrowIfNull(
#if !NETSTANDARD2_0
        [NotNull]
#endif
        object? argument,
#if !NETSTANDARD
        [CallerArgumentExpression(nameof(argument))]
#endif
        string? paramName = null)
    {
        if(argument is null)
        {
            throw new ArgumentNullException(paramName);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="argument"></param>
    /// <param name="paramName"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void ThrowIfNullOrEmpty(string argument,
#if !NETSTANDARD
        [CallerArgumentExpression(nameof(argument))]
#endif
        string? paramName = null)
    {
        if(string.IsNullOrEmpty(argument))
        {
            throw new ArgumentException($"Argument is null or empty.", paramName);
        }
    }
}