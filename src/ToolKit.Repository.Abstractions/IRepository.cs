using System.Linq.Expressions;

namespace Sharemee.ToolKit.Repository.Abstractions;

public interface IRepository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> where);

    TEntity? FindById(long id);
}
