using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Sharemee.ToolKit.Repository.Abstractions;

public interface IRepositoryAsync<TEntity> where TEntity : class
{

    ValueTask<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> where);

    ValueTask<TEntity?> FindByIdAsync(long id);
}
