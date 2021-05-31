using MarketPlace.Domain.Entities;
using MarketPlace.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Marketplace.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoRepository produtoRepository, IProdutoService produtoService)
        {
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
        }

        // GET: api/<ProdutoController>
        [HttpGet]
        public async Task<IEnumerable<Produto>> ObterTodos()
        {
            return await _produtoRepository.ObterTodos();
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _produtoRepository.ObterPorId(id);
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public async Task<ActionResult<Produto>> Adicionar(Produto produto)
        {
            await _produtoService.Adicionar(produto);
            return Ok(produto);
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Produto>> Atualizar(Guid id, Produto produtoAtual)
        {
            var produto = await _produtoRepository.ObterPorId(id);
            if (produto == null) return NotFound();

            produto.Nome = produtoAtual.Nome;

            await _produtoService.Atualizar(produto);
            return Ok(produto);
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Produto>> Excluir(Guid id)
        {
            var produto = await _produtoRepository.ObterPorId(id);
            if (produto == null) return NotFound();

            await _produtoService.Remover(produto);
            return Ok(produto);                  
        }
    }
}
