using MarketPlace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity 
    {
        Task<TEntity> ObterPorId(Guid id);      
        Task<List<TEntity>> ObterTodos();       
        Task Adicinar(TEntity entity);
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task Remover(TEntity entity);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
