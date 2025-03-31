using System.Linq.Expressions;

namespace Places.Application.Common;

public interface IService<TModel> where TModel : EntityBase
{
    public Task<TModel> Create(TModel model);

    public Task Delete(int id);

    public Task<TModel> Edit(TModel model);

    public Task<IEnumerable<TModel>> GetAll();

    public Task<TModel> GetById(int id);

    public Task<bool> Any();

    public Task<bool> Any(Expression<Func<TModel, bool>> predicate);

    public Task<QueryResult<TModel>> GetByQueryRequestAsync(QueryRequest queryRequest);
}