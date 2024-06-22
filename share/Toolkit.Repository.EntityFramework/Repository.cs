using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sharemee.ToolKit.Repository.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework;

/// <summary>
/// 
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
}
