using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task<RetornoApi<ProdutoDTO>> BuscarProduto(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<List<ProdutoDTO>>> BuscarTodosOsProdutos()
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<ProdutoDTO>> CriarProduto(ProdutoDTO produtoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<ProdutoDTO>> DeletarProduto(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<ProdutoDTO>> EditarProduto(Guid id, ProdutoDTO produtoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
