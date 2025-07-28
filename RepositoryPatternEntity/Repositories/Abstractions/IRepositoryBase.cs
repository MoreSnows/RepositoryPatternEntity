using System.Linq.Expressions;
using Core;

namespace RepositoryPatternEntity.Repositories.Abstractions
{
    public interface IRepositoryBase<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> ObterPorIdAsync(Guid id);
        Task AddAsync(TEntity entity);
        Task DeletarAsync(TEntity entity);
        Task Atualizar(TEntity entity);
    }
}
