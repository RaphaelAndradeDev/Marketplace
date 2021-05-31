using MarketPlace.Domain.Entities;
using MarketPlace.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarketPlace.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }


        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _produtoRepository.ObterPorId(id);
        }

        public async Task<List<Produto>> ObterTodos()
        {
            return await _produtoRepository.ObterTodos();
        }

        public async Task Adicionar(Produto produto)
        {
            await _produtoRepository.Adicinar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            await _produtoRepository.Atualizar(produto);
        }                

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public async Task Remover(Produto produto)
        {
            await _produtoRepository.Remover(produto);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }       
    }
}
