
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;

namespace SalesLinkPRO.Infra.Data.Interfaces
{
    public interface IClienteRepository
    {
        Task<RetornoApi<List<Cliente>>> BuscarTodosOsCliente();
        Task<RetornoApi<Cliente>> BuscarCliente(string id);
        Task<RetornoApi<Cliente>> CriarCliente(Cliente clienteDTO);
        Task<RetornoApi<Cliente>> EditarCliente(string id, Cliente clienteDTO);
        Task<RetornoApi<Cliente>> AtualizarStatusCliente(string id, StatusUsuario statusCliente);
        Task<RetornoApi<Cliente>> DeletarCliente(string id);
    }
}
