using Microsoft.EntityFrameworkCore;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;
using System.Net;

namespace SalesLinkPRO.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<RetornoApi<Cliente>> BuscarCliente(string id)
        {
            try
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    Message = $"Cliente de Id: {id} não encontrado!",
                    StatusCode = HttpStatusCode.NotFound
                };

                var cliente = await _context.Cliente.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

                if (cliente == null)
                    return retorno;

                retorno.StatusCode = HttpStatusCode.OK;
                retorno.Data = cliente;
                retorno.Success = true;

                return retorno;
            }
            catch (Exception ex)
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    Message = $"Erro ao buscar o cliente de Id: {id}",
                    StatusCode = HttpStatusCode.InternalServerError
                };

                retorno.Errors.Add(ex.Message);

                return retorno;
            }
        }

        public async Task<RetornoApi<List<Cliente>>> BuscarTodosOsCliente()
        {
            try
            {
                RetornoApi<List<Cliente>> retorno = new RetornoApi<List<Cliente>>()
                {
                    Success = false,
                    Message = $"Nenhum cliente encontrado!",
                    StatusCode = HttpStatusCode.NotFound
                };

                var Cliente = await _context.Cliente.ToListAsync();

                if (Cliente.Any())
                {
                    retorno.Success = true;
                    retorno.Data = Cliente;
                    retorno.StatusCode = HttpStatusCode.OK;
                    retorno.Message = "Cliente encontrados com sucesso";
                    return retorno;
                }

                retorno.Data = Cliente;
                return retorno;
            }
            catch (Exception ex)
            {
                RetornoApi<List<Cliente>> retorno = new RetornoApi<List<Cliente>>()
                {
                    Success = false,
                    StatusCode = HttpStatusCode.InternalServerError
                };

                retorno.Errors.Add(ex.Message);

                return retorno;
            }
        }

        public async Task<RetornoApi<Cliente>> CriarCliente(Cliente clienteDTO)
        {
            try
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    Message = $"Não foi possível criar o cliente!",
                    StatusCode = HttpStatusCode.BadRequest
                };

                clienteDTO.Id = Guid.NewGuid(); // Atribui um novo Guid ao cliente

                await _context.Cliente.AddAsync(clienteDTO);
                await _context.SaveChangesAsync();

                retorno.Message = "Cliente Criado Com Sucesso";
                retorno.StatusCode = HttpStatusCode.OK;
                retorno.Message = "Cliente criado com sucesso";
                retorno.Success = true;
                retorno.Data = clienteDTO;

                return retorno;
            }
            catch (Exception ex)
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    StatusCode = HttpStatusCode.InternalServerError
                };

                retorno.Errors.Add(ex.Message);

                return retorno;
            }
        }

        public async Task<RetornoApi<Cliente>> DeletarCliente(string id)
        {
            try
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    StatusCode = HttpStatusCode.NotFound
                };

                var cliente = await _context.Cliente.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

                if (cliente == null)
                {
                    retorno.Message = $"Cliente não encontrado!";
                    return retorno;
                }

                _context.Cliente.Remove(cliente);
                await _context.SaveChangesAsync();

                retorno.Success = true;
                retorno.Message = $"Cliente deletado com sucesso!";
                retorno.StatusCode = HttpStatusCode.OK;

                return retorno;
            }
            catch (Exception ex)
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    StatusCode = HttpStatusCode.InternalServerError
                };

                retorno.Errors.Add(ex.Message);

                return retorno;
            }
        }

        public async Task<RetornoApi<Cliente>> EditarCliente(string id, Cliente clienteDTO)
        {
            try
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    Message = $"Não foi possível atualizar o cliente!",
                    StatusCode = HttpStatusCode.BadRequest
                };

                var clienteAtual = await _context.Cliente.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

                if (clienteAtual == null)
                {
                    retorno.Errors.Add("Cliente não encontrado");
                    return retorno;
                }

                clienteAtual.Nome = clienteDTO.Nome; // Adicione outras atualizações conforme necessário

                await _context.SaveChangesAsync();

                retorno.Success = true;
                retorno.StatusCode = HttpStatusCode.OK;
                retorno.Message = "Cliente atualizado com sucesso";
                return retorno;
            }
            catch (Exception ex)
            {
                RetornoApi<Cliente> retorno = new RetornoApi<Cliente>()
                {
                    Success = false,
                    StatusCode = HttpStatusCode.InternalServerError
                };

                retorno.Errors.Add(ex.Message);
                return retorno;
            }
        }

        public Task<RetornoApi<Cliente>> AtualizarStatusCliente(string id, StatusUsuario statusCliente)
        {
            throw new NotImplementedException();
        }
    }
}
