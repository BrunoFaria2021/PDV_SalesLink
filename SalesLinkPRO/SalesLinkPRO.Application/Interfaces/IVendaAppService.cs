using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.CrossCutting.Extensions;

namespace SalesLinkPRO.Application.Interfaces
{
    public interface IVendaAppService
    {
        Task<RetornoApi<List<VendaDTO>>> BuscarTodasAsVendas(Guid clienteId);
        Task<RetornoApi<VendaDTO>> BuscarVenda(Guid id, Guid clienteId);
        Task<RetornoApi<VendaDTO>> CriarVenda(VendaDTO vendaDTO);
        Task<RetornoApi<VendaDTO>> EditarVenda(Guid id, Guid clienteId, VendaDTO vendaDTO);
        Task<RetornoApi<VendaDTO>> DeletarVenda(Guid id, Guid clienteId);
    }
}
