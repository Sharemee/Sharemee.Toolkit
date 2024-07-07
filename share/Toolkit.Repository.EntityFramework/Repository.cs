using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sharemee.Toolkit.Http;
using Sharemee.ToolKit.Repository.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework;

/// <summary>
/// 泛型仓储实现
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// 
    /// </summary>
    public readonly DbContext DbContext;

    /// <summary>
    /// 
    /// </summary>
    public readonly DbSet<TEntity> Entity;


    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContext"></param>
    public Repository(DbContext dbContext)
    {
        this.DbContext = dbContext;
        Entity = dbContext.Set<TEntity>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public virtual IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> where)
    {
        var body = (MethodCallExpression)where.Body;
        foreach (var arg in body.Arguments)
        {
            Console.WriteLine($"Parameter Type: {arg.Type.Name}");
            Console.WriteLine($"Parameter Node Type: {arg.NodeType}");
        }
        return Entity.AsNoTracking().Where(where);
    }

    /// <summary>
    /// 通过ID查找
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual TEntity? FindById(long id) => Entity.Find(id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual async ValueTask<TEntity?> FindByIdAsync(long id)
        => await Entity.FindAsync(id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public virtual TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> where)
        => Entity.FirstOrDefault(where);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public virtual async ValueTask<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> where)
        => await Entity.FirstOrDefaultAsync(where);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="expression"></param>
    /// <returns></returns>
    public virtual IQueryable<TResult> QueryAll<TResult>(Expression<Func<TEntity, TResult>> expression)
    {
        return Entity.AsQueryable().Select(expression);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int Count(Expression<Func<TEntity, bool>> where)
    {
        return Entity.Count(where);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pagination"></param>
    /// <returns></returns>
    public PaginationResult<TEntity> Pagination(IPagination pagination)
    {
        var result = new PaginationResult<TEntity>(pagination);

        var query = Entity.AsNoTracking();
        result.TotalCount = query.Count();
        result.PageCount = (int)Math.Ceiling(result.TotalCount / (double)result.PageSize);
        result.Values = [.. query];
        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <param name="pagination"></param>
    /// <returns></returns>
    public PaginationResult<TEntity> Pagination(Expression<Func<TEntity, bool>> where, IPagination pagination)
    {
        var result = new PaginationResult<TEntity>(pagination);

        var query = Entity.AsNoTracking().Where(where);
        result.TotalCount = query.Count();
        if (result.TotalCount > 0)
        {
            result.PageCount = (int)Math.Ceiling(result.TotalCount / (double)result.PageSize);
            result.Values = [.. query];
        }
        return result;
    }

}
