using SalesLinkPRO.Application.DTO;
using SalesLinkPRO.Application.Interfaces;
using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Application.Services
{
    public class ConsultorAppService : IConsultorAppService
    {
        private readonly IConsultorRepository _consultorRepository;

        public ConsultorAppService(IConsultorRepository consultorRepository)
        {
            _consultorRepository = consultorRepository;
        }

        public Task<RetornoApi<ConsultorDTO>> BuscarConsultor(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<List<ConsultorDTO>>> BuscarTodosOsConsultores()
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<ConsultorDTO>> CriarConsultor(ConsultorDTO consultorDTO)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<ConsultorDTO>> DeletarConsultor(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RetornoApi<ConsultorDTO>> EditarConsultor(Guid id, ConsultorDTO consultorDTO)
        {
            throw new NotImplementedException();
        }
    }
}
