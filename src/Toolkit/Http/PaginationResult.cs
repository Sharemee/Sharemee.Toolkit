namespace Sharemee.Toolkit.Http;

/// <summary>
/// 分页数据模型
/// </summary>
/// <typeparam name="T"></typeparam>
public class PaginationResult<T> : Pagination, IPagination
{
    /// <summary>
    /// 总页数
    /// </summary>
    public int PageCount { get; set; }

    /// <summary>
    /// 总条数
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// 当前页数据集合
    /// </summary>
    public IEnumerable<T> Values { get; set; } = null!;
}
