using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Application.Services
{
    public class PagamentoAppService : IPagamentoAppService
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoAppService(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public Task<RetornoApi<PagamentoDTO>> BuscarPagamento(Guid id, Guid vendaId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<List<PagamentoDTO>>> BuscarTodosOsPagamentos(Guid vendaId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<PagamentoDTO>> CriarPagamento(PagamentoDTO pagamentoDTO)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<PagamentoDTO>> DeletarPagamento(Guid id, Guid vendaId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<PagamentoDTO>> EditarPagamento(Guid id, Guid vendaId, PagamentoDTO pagamentoDTO)
        {
            throw new NotImplementedException();
        }
    }
}
