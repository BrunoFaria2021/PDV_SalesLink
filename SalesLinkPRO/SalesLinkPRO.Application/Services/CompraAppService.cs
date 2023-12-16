using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Application.Services
{
    public class CompraAppService : ICompraAppService
    {
        private readonly ICompraRepository _compraRepository;

        public CompraAppService(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public Task<RetornoApi<CompraDTO>> BuscarCompra(Guid id, Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<List<CompraDTO>>> BuscarTodasAsCompras(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<CompraDTO>> CriarCompra(CompraDTO compraDTO)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<CompraDTO>> DeletarCompra(Guid id, Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<CompraDTO>> EditarCompra(Guid id, Guid clienteId, CompraDTO compraDTO)
        {
            throw new NotImplementedException();
        }
    }
}
