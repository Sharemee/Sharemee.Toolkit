namespace Sharemee.Toolkit.Http;

/// <summary>
/// 分页模型
/// </summary>
public class Pagination : IPagination
{
    public Pagination()
    {
        
    }

    public Pagination(int pageNo, int pageSize)
    {
        this.PageNo = pageNo;
        this.PageSize = pageSize;
    }

    /// <inheritdoc/>
    public int PageNo { get; set; } = 1;

    /// <inheritdoc/>
    public int PageSize { get; set; } = 10;
}
