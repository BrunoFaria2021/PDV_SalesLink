using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Infra.Data.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly ApplicationDbContext _context;

        public PagamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public RetornoApi<Pagamento> BuscarConsultor(Guid id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<List<Pagamento>> BuscarTodosOsConsultor()
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Pagamento> CriarPagamento(Pagamento pagamentoDTO)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Pagamento> DeletarPagamento(Guid id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Pagamento> EditarPagamento(Guid id, Pagamento pagamentoDTO)
        {
            throw new NotImplementedException();
        }
    }
}

