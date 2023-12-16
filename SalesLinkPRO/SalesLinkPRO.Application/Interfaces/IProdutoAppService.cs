using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.CrossCutting.Extensions;

namespace SalesLinkPRO.Application.Interfaces
{
    public interface IProdutoAppService
    {
        Task<RetornoApi<List<ProdutoDTO>>> BuscarTodosOsProdutos();
        Task<RetornoApi<ProdutoDTO>> BuscarProduto(Guid id);
        Task<RetornoApi<ProdutoDTO>> CriarProduto(ProdutoDTO produtoDTO);
        Task<RetornoApi<ProdutoDTO>> EditarProduto(Guid id, ProdutoDTO produtoDTO);
        Task<RetornoApi<ProdutoDTO>> DeletarProduto(Guid id);
    }
}
