using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.CrossCutting.Extensions;

namespace SalesLinkPRO.Application.Interfaces
{

    public interface ICompraAppService
    {
        Task<RetornoApi<List<CompraDTO>>> BuscarTodasAsCompras(Guid clienteId);
        Task<RetornoApi<CompraDTO>> BuscarCompra(Guid id, Guid clienteId);
        Task<RetornoApi<CompraDTO>> CriarCompra(CompraDTO compraDTO);
        Task<RetornoApi<CompraDTO>> EditarCompra(Guid id, Guid clienteId, CompraDTO compraDTO);
        Task<RetornoApi<CompraDTO>> DeletarCompra(Guid id, Guid clienteId);
    }
}
