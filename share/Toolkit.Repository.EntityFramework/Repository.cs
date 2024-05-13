using Microsoft.EntityFrameworkCore;
using Sharemee.Toolkit.Repository.EntityFramework.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class Repository<TEntity> : RepositoryBase<TEntity> where TEntity : class
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContext"></param>
    public Repository(DbContext dbContext) : base(dbContext)
    {
    }
}
