using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.CrossCutting.Extensions;

namespace SalesLinkPRO.Application.Interfaces
{
    public interface IPagamentoAppService
    {
        Task<RetornoApi<List<PagamentoDTO>>> BuscarTodosOsPagamentos(Guid vendaId);
        Task<RetornoApi<PagamentoDTO>> BuscarPagamento(Guid id, Guid vendaId);
        Task<RetornoApi<PagamentoDTO>> CriarPagamento(PagamentoDTO pagamentoDTO);
        Task<RetornoApi<PagamentoDTO>> EditarPagamento(Guid id, Guid vendaId, PagamentoDTO pagamentoDTO);
        Task<RetornoApi<PagamentoDTO>> DeletarPagamento(Guid id, Guid vendaId);
    }
}
