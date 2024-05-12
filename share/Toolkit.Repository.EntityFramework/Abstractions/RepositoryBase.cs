using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Sharemee.ToolKit.Repository.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework.Abstractions;

public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext dbContext;
    private readonly DbSet<TEntity> entity;

    protected RepositoryBase(DbContext dbContext)
    {
        this.dbContext = dbContext;
        entity = dbContext.Set<TEntity>();
    }

    public virtual TEntity? FindById(long id) => entity.Find(id);

    public virtual async ValueTask<TEntity?> FindByIdAsync(long id) => await entity.FindAsync(id);

    public virtual TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> where) => entity.FirstOrDefault(where);

    public virtual async ValueTask<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> where) => await entity.FirstOrDefaultAsync(where);
}
