using Microsoft.AspNetCore.Mvc;
using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;

namespace SalesLinkPRO.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpGet("todos/{ClienteId}")]
        public async Task<IActionResult> GetAll([FromRoute] Guid consultorId)
        {
            var result = await _clienteAppService.BuscarTodosOsClientes(consultorId);

            if (!result.Success)
            {
                return StatusCode((int)result.StatusCode, result.Message);
            }

            return Ok(result.Data);
        }

        [HttpGet("{id}/{ClienteId}")]
        public async Task<IActionResult> Get(Guid id, [FromRoute] Guid consultorId)
        {
            var result = await _clienteAppService.BuscarCliente(id, consultorId);

            if (!result.Success)
            {
                return StatusCode((int)result.StatusCode, result.Message);
            }

            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ClienteDTO cliente)
        {
            var result = await _clienteAppService.CriarCliente(cliente);

            if (!result.Success)
            {
                return StatusCode((int)result.StatusCode, result.Message);
            }

            return Ok(result.Message);
        }

        [HttpPut("{id}/{consultorId}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromRoute] Guid consultorId, [FromBody] ClienteDTO cliente)
        {
            var result = await _clienteAppService.EditarCliente(id, consultorId, cliente);

            if (!result.Success)
            {
                return StatusCode((int)result.StatusCode, result.Message);
            }

            return Ok(result.Message);
        }

        [HttpDelete("{id}/{consultorId}")]
        public async Task<IActionResult> Delete(Guid id, [FromRoute] Guid consultorId)
        {
            var result = await _clienteAppService.DeletarCliente(id, consultorId);

            if (!result.Success)
            {
                return StatusCode((int)result.StatusCode, result.Message);
            }

            return Ok(result.Message);
        }
    }
}
