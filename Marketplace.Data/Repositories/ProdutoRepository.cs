using Marketplace.Data.Context;
using MarketPlace.Domain.Entities;
using MarketPlace.Domain.Interfaces;

namespace Marketplace.Data.Repositories
{
    public class ProdutoRepository : EF_Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context) { }
        
    }
}
