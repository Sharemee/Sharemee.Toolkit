using System.Linq.Expressions;
using Sharemee.Toolkit.Http;

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
    IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> where);

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

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IQueryable<TResult> QueryAll<TResult>(Expression<Func<TEntity, TResult>> expression);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <returns></returns>
    int Count(Expression<Func<TEntity, bool>> where);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="pagination"></param>
    /// <returns></returns>
    PaginationResult<TEntity> Pagination(IPagination pagination);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="where"></param>
    /// <param name="pagination"></param>
    /// <returns></returns>
    PaginationResult<TEntity> Pagination(Expression<Func<TEntity, bool>> where, IPagination pagination);
}
