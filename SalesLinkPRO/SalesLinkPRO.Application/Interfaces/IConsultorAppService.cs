using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.CrossCutting.Extensions;

namespace SalesLinkPRO.Application.Interfaces
{
    public interface IConsultorAppService
    {
        Task<RetornoApi<List<ConsultorDTO>>> BuscarTodosOsConsultores();
        Task<RetornoApi<ConsultorDTO>> BuscarConsultor(Guid id);
        Task<RetornoApi<ConsultorDTO>> CriarConsultor(ConsultorDTO consultorDTO);
        Task<RetornoApi<ConsultorDTO>> EditarConsultor(Guid id, ConsultorDTO consultorDTO);
        Task<RetornoApi<ConsultorDTO>> DeletarConsultor(Guid id);
    }
}
