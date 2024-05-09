using System.Linq.Expressions;

namespace Sharemee.ToolKit.Repository.Abstractions;

/// <summary>
/// 泛型仓储
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IRepositoryAsync<TEntity> where TEntity : class
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    ValueTask<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> where);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    ValueTask<TEntity?> FindByIdAsync(long id);
}
