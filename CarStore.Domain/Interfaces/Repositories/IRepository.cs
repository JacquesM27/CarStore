using CarStore.Domain.Models;
using System.Linq.Expressions;

namespace CarStore.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity, TId>
        where TId : notnull
        where TEntity : Entity<TId>
    {
        IQueryable<TEntity> AsQueryable();

        IEnumerable<TEntity> FilterBy(
        Expression<Func<TEntity, bool>> filterExpression);

        IEnumerable<TProjected> FilterBy<TProjected>(
            Expression<Func<TEntity, bool>> filterExpression,
            Expression<Func<TEntity, TProjected>> projectionExpression);

        Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> filterExpression);

        Task<TEntity> FindByIdAsync(TId id);

        Task InsertOneAsync(TEntity entity);

        Task InsertManyAsync(IEnumerable<TEntity> entities);

        Task UpdateOneAsync(TEntity entity);

        Task DeleteAsync(Expression<Func<TEntity, bool>> filterExpression);

        Task DeleteOneAsync(TId id);

        Task DeleteManyAsync(Expression<Func<TEntity, bool>> filterExpression);

        Task ReplaceOneAsync(TEntity entity);
    }
}
