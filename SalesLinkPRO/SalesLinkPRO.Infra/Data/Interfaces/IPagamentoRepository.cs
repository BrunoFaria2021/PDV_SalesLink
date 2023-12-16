using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;

namespace SalesLinkPRO.Infra.Data.Interfaces
{
    public interface IPagamentoRepository
    {
        RetornoApi<List<Pagamento>> BuscarTodosOsConsultor();
        RetornoApi<Pagamento> BuscarConsultor(Guid id);
        RetornoApi<Pagamento> CriarPagamento(Pagamento pagamentoDTO);
        RetornoApi<Pagamento> EditarPagamento(Guid id, Pagamento pagamentoDTO);
        RetornoApi<Pagamento> DeletarPagamento(Guid id);
    }
}
