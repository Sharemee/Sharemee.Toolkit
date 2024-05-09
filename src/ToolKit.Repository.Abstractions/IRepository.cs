using System.Linq.Expressions;

namespace Sharemee.ToolKit.Repository.Abstractions;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> where);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    TEntity? FindById(long id);
}
