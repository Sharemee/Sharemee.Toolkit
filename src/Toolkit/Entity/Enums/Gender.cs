using System.ComponentModel;

namespace Sharemee.Toolkit.Entity.Enums;

/// <summary>
/// 性别
/// </summary>
public enum Gender : ushort
{
    /// <summary>
    /// 保密
    /// </summary>
    [Description("保密")]
    Secret = 0,

    /// <summary>
    /// 男
    /// </summary>
    [Description("男")]
    Male,
    /// <summary>
    /// 女
    /// </summary>
    [Description("女")]
    Female,
}
