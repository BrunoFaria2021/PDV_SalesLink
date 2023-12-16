using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Application.Services
{
    public class VendaAppService : IVendaAppService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaAppService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public Task<RetornoApi<List<VendaDTO>>> BuscarTodasAsVendas(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<VendaDTO>> BuscarVenda(Guid id, Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<VendaDTO>> CriarVenda(VendaDTO vendaDTO)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<VendaDTO>> DeletarVenda(Guid id, Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<VendaDTO>> EditarVenda(Guid id, Guid clienteId, VendaDTO vendaDTO)
        {
            throw new NotImplementedException();
        }
    }
}
