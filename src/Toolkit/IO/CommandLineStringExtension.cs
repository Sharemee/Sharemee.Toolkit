using System.Diagnostics;
using System.Text;

namespace Sharemee.Toolkit.IO;

public static class CommandLineStringExtension
{
    /// <summary>
    /// 将命令行字符串准确拆分成命令行参数列表
    /// </summary>
    /// <param name="commandString">命令行字符串</param>
    /// <returns>命令行参数集合</returns>
    public static List<string> ConvertToCommandLineArgs(this string commandString)
    {
        List<string> args = [];

        if (string.IsNullOrEmpty(commandString))
        {
            return args;
        }

        int index = 0;
        int stringLenght = commandString.Length;
        while (index < stringLenght)
        {
            StringBuilder sb = new();
            for (; index < stringLenght; index++)
            {
                char c = commandString[index];

                CharType charType = GetCharType(c);
                if (charType == CharType.Normal)
                {
                    sb.Append(c);
                    continue;
                }
                if (charType == CharType.Space)
                {
                    if (sb.Length == 0)
                    {
                        continue;
                    }
                    else
                    {
                        index++;
                        break;
                    }
                }
                if (charType == CharType.QuotationMark)
                {
                    bool isLeft = false;
                    bool isRight = false;

                    StringBuilder sbq = new();
                    for (; index < stringLenght; index++)
                    {
                        if (isLeft && isRight) break;

                        charType = GetCharType(c);
                        if (charType == CharType.Normal)
                        {
                            sbq.Append(c);
                            continue;
                        }
                        if (charType == CharType.QuotationMark)
                        {
                            if (isLeft)
                            {
                                isRight = true;
                            }
                            else
                            {
                                isLeft = true;
                            }
                            //注意: 千万不要Append(c), sb本身就是字符串(什么都不加就是空字符串), 你又加两个双引号(它就不空了), 你细品
                            //sbq.Append(c);
                            continue;
                        }
                        if (charType == CharType.Space)
                        {
                            sbq.Append(c);
                            continue;
                        }
                    }
                    sb.Append(sbq.ToString());
                    continue;
                }
            }
            args.Add(sb.ToString());
        }
        return args;
    }

    /// <summary>
    /// 获取字符类型
    /// </summary>
    /// <param name="c">待获取类型的字符</param>
    /// <returns><see cref="CharType"/></returns>
    [DebuggerStepThrough]
    private static CharType GetCharType(char c)
    {
        return c switch
        {
            ' ' => CharType.Space,
            '"' => CharType.QuotationMark,
            _ => CharType.Normal,
        };
    }

    /// <summary>
    /// 字符类型
    /// </summary>
    public enum CharType
    {
        /// <summary>
        /// 正常字符
        /// </summary>
        Normal,
        /// <summary>
        /// 空格
        /// </summary>
        Space,
        /// <summary>
        /// 引号
        /// </summary>
        QuotationMark,
    }
}
