using System.Reflection;

namespace Sharemee.Toolkit.Extensions;

/// <summary>
/// 
/// </summary>
public static class MethodInfoExtension
{
    /// <summary>
    /// 查找方法指定特性，如果没找到则继续查找声明类
    /// </summary>
    /// <typeparam name="TAttribute"></typeparam>
    /// <param name="method"></param>
    /// <param name="inherit"></param>
    /// <returns></returns>
    public static TAttribute? GetAttributeWithDeclaringType<TAttribute>(this MethodInfo method, bool inherit = false)
        where TAttribute : Attribute
    {
        if (TryGetAttribute(method, out TAttribute? attribute, inherit))
        {
            return attribute;
        }
        else
        {
            // 获取方法所在类型
            Type declaringType = method.DeclaringType!;

            bool isDefined = declaringType.IsDefined(typeof(TAttribute), inherit);
            if (isDefined)
            {
                return declaringType.GetCustomAttribute<TAttribute>(inherit)!;
            }
            else
            {
                return default;
            }
        }
    }

    /// <summary>
    /// 尝试获取指定的特性标记
    /// </summary>
    /// <typeparam name="TAttribute"></typeparam>
    /// <param name="methodInfo"></param>
    /// <param name="attribute"></param>
    /// <param name="inherit"></param>
    /// <returns></returns>
    public static bool TryGetAttribute<TAttribute>(this MethodInfo methodInfo, out TAttribute? attribute, bool inherit = false)
        where TAttribute : Attribute
    {
        bool isDefine = methodInfo.IsDefined(typeof(TAttribute));
        if (isDefine)
        {
            attribute = methodInfo.GetCustomAttribute<TAttribute>(inherit)!;
        }
        else
        {
            attribute = default;
        }
        return isDefine;
    }
}
