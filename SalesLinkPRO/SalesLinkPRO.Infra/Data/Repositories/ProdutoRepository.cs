using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public RetornoApi<Produto> BuscarProduto(Guid id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<List<Produto>> BuscarToodosProduto()
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Produto> CriarProduto(Pagamento pagamentoDTO)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Produto> DeletarProduto(Guid id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Produto> EditarProduto(Guid id, Pagamento pagamentoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
