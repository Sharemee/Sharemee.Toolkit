using Microsoft.EntityFrameworkCore;
using Sharemee.Toolkit.Repository.EntityFramework.Abstractions;

namespace Sharemee.Toolkit.Repository.EntityFramework;

public class Repository<TEntity> : RepositoryBase<TEntity> where TEntity : class
{
    public Repository(DbContext dbContext) : base(dbContext)
    {
    }
}
