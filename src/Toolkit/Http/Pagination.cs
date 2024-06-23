namespace Sharemee.Toolkit.Http;

/// <summary>
/// 分页模型接口
/// </summary>
public interface IPagination
{
    /// <summary>
    /// 当前页码
    /// </summary>
    int PageNo { get; set; }

    /// <summary>
    /// 每页数据容量
    /// </summary>
    int PageSize { get; set; }
}

/// <summary>
/// 分页模型
/// </summary>
public class Pagination : IPagination
{
    /// <inheritdoc/>
    public int PageNo { get; set; }

    /// <inheritdoc/>
    public int PageSize { get; set; }
}
