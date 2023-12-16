using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.CrossCutting.Util;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Infra.Data.Repositories
{
    public class VendaRepository : IVendaRepository
    {
        private readonly ApplicationDbContext _context;

        public VendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public RetornoApi<Venda> AtualizarStatusVenda(string id, EnumStatusVenda statusVenda)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<List<Venda>> BuscarTodasAsVendas()
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Venda> BuscarVenda(string id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Venda> CriarVenda(Venda vendaDTO)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Venda> DeletarVenda(string id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Venda> EditarVenda(string id, Venda vendaDTO)
        {
            throw new NotImplementedException();
        }
    }

}
