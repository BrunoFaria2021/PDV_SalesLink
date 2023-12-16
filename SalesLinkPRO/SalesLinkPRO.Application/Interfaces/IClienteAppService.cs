using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.CrossCutting.Extensions;

namespace SalesLinkPRO.Application.Interfaces
{
    public interface IClienteAppService
    {
        Task<RetornoApi<List<ClienteDTO>>> BuscarTodosOsClientes(Guid consultorId);
        Task<RetornoApi<ClienteDTO>> BuscarCliente(Guid id, Guid consultorId);
        Task<RetornoApi<ClienteDTO>> CriarCliente(ClienteDTO clienteDTO);
        Task<RetornoApi<ClienteDTO>> EditarCliente(Guid id, Guid consultorId, ClienteDTO clienteDTO);
        Task<RetornoApi<ClienteDTO>> DeletarCliente(Guid id, Guid consultorId);
    }
}
