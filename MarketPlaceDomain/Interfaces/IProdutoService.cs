using MarketPlace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task<List<Produto>> ObterTodos();
        Task<Produto> ObterPorId(Guid id);
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
