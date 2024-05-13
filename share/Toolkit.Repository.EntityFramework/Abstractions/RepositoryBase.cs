using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sharemee.ToolKit.Repository.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework.Abstractions;

/// <summary>
/// 泛型仓储基类, 实现了一些基础方法
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext dbContext;
    private readonly DbSet<TEntity> entity;

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="dbContext"></param>
    protected RepositoryBase(DbContext dbContext)
    {
        this.dbContext = dbContext;
        entity = dbContext.Set<TEntity>();
    }

    /// <summary>
    /// 通过ID查找
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual TEntity? FindById(long id) => entity.Find(id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual async ValueTask<TEntity?> FindByIdAsync(long id) => await entity.FindAsync(id);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public virtual TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> where) => entity.FirstOrDefault(where);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    public virtual async ValueTask<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> where) => await entity.FirstOrDefaultAsync(where);
}
