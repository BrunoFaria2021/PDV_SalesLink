using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;

namespace SalesLinkPRO.Infra.Data.Interfaces
{
    public interface IProdutoRepository
    {
        RetornoApi<List<Produto>> BuscarToodosProduto();
        RetornoApi<Produto> BuscarProduto(Guid id);
        RetornoApi<Produto> CriarProduto(Pagamento pagamentoDTO);
        RetornoApi<Produto> EditarProduto(Guid id, Pagamento pagamentoDTO);
        RetornoApi<Produto> DeletarProduto(Guid id);
    }
}
