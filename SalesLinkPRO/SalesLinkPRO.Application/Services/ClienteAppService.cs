using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;
using System.Net;

namespace SalesLinkPRO.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteAppService(IClienteRepository clienteRepository)
        { 
            _clienteRepository = clienteRepository;
        }

        public async Task<RetornoApi<ClienteDTO>> BuscarCliente(Guid id, Guid consultorId)
        {
            var retorno = new RetornoApi<ClienteDTO>();

            var result = await _clienteRepository.BuscarCliente(id.ToString());

            if (result == null || !result.Success)
            {
                retorno.StatusCode = HttpStatusCode.NotFound;
                retorno.Message = $"Cliente de Id: {id} não encontrado!";
                retorno.Success = false;
                return retorno;
            }

            retorno.StatusCode = HttpStatusCode.OK;
            retorno.Message = "Cliente encontrado com sucesso";
            retorno.Success = true;
            retorno.Data = new ClienteDTO
            {
                Id = result.Data.Id,
                Nome = result.Data.Nome,
                CPF = result.Data.CPF,
                Email = result.Data.Email,
                Endereco = result.Data.Endereco,
                DataCadastro = result.Data.DataCadastro
            };

            return retorno;
        }

        public async Task<RetornoApi<List<ClienteDTO>>> BuscarTodosOsClientes(Guid consultorId)
        {
            var retorno = new RetornoApi<List<ClienteDTO>>();

            var result = await _clienteRepository.BuscarTodosOsCliente();

            if (result == null || !result.Success || result.Data == null || result.Data.Count == 0)
            {
                retorno.StatusCode = HttpStatusCode.NotFound;
                retorno.Message = "Nenhum cliente cadastrado!";
                retorno.Success = false;
                return retorno;
            }

            var listaClientes = new List<ClienteDTO>();

            foreach (var cliente in result.Data)
            {
                listaClientes.Add(new ClienteDTO
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    CPF = cliente.CPF,
                    Email = cliente.Email,
                    Endereco = cliente.Endereco,
                    DataCadastro = cliente.DataCadastro
                });
            }

            retorno.StatusCode = HttpStatusCode.OK;
            retorno.Message = "Clientes encontrados com sucesso";
            retorno.Success = true;
            retorno.Data = listaClientes;

            return retorno;
        }

        public async Task<RetornoApi<ClienteDTO>> CriarCliente(ClienteDTO clienteDTO)
        {
            var retorno = new RetornoApi<ClienteDTO>();

            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = clienteDTO.Nome,
                CPF = clienteDTO.CPF,
                Email = clienteDTO.Email,
                Endereco = clienteDTO.Endereco,
                DataCadastro = DateTime.Now
            };

            var result = await _clienteRepository.CriarCliente(cliente);

            if (result == null || !result.Success)
            {
                retorno.StatusCode = HttpStatusCode.InternalServerError;
                retorno.Message = "Erro ao criar o Cliente";
                retorno.Success = false;
                return retorno;
            }

            retorno.StatusCode = HttpStatusCode.Created;
            retorno.Message = "Cliente criado com sucesso!";
            retorno.Success = true;
            retorno.Data = new ClienteDTO
            {
                Id = result.Data.Id,
                Nome = result.Data.Nome,
                CPF = result.Data.CPF,
                Email = result.Data.Email,
                Endereco = result.Data.Endereco,
                DataCadastro = result.Data.DataCadastro
            };

            return retorno;
        }

        public async Task<RetornoApi<ClienteDTO>> DeletarCliente(Guid id, Guid consultorId)
        {
            var retorno = new RetornoApi<ClienteDTO>();

            var result = await _clienteRepository.DeletarCliente(id.ToString());

            if (result == null || !result.Success)
            {
                retorno.StatusCode = HttpStatusCode.InternalServerError;
                retorno.Message = "Erro ao deletar o Cliente";
                retorno.Success = false;
                return retorno;
            }

            retorno.StatusCode = HttpStatusCode.OK;
            retorno.Message = "Cliente deletado com sucesso";
            retorno.Success = true;

            return retorno;
        }

        public async Task<RetornoApi<ClienteDTO>> EditarCliente(Guid id, Guid consultorId, ClienteDTO clienteDTO)
        {
            var retorno = new RetornoApi<ClienteDTO>();

            var cliente = new Cliente
            {
                Id = id,
                Nome = clienteDTO.Nome,
                CPF = clienteDTO.CPF,
                Email = clienteDTO.Email,
                Endereco = clienteDTO.Endereco,
                DataCadastro = clienteDTO.DataCadastro
            };

            var result = await _clienteRepository.EditarCliente(id.ToString(), cliente);

            if (result == null || !result.Success)
            {
                retorno.StatusCode = HttpStatusCode.InternalServerError;
                retorno.Message = "Erro ao editar o Cliente";
                retorno.Success = false;
                return retorno;
            }

            retorno.StatusCode = HttpStatusCode.OK;
            retorno.Message = "Cliente editado com sucesso";
            retorno.Success = true;
            retorno.Data = new ClienteDTO
            {
                Id = result.Data.Id,
                Nome = result.Data.Nome,
                CPF = result.Data.CPF,
                Email = result.Data.Email,
                Endereco = result.Data.Endereco,
                DataCadastro = result.Data.DataCadastro
            };

            return retorno;
        }
    }
}
