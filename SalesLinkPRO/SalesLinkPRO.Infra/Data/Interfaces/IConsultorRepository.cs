using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;

namespace SalesLinkPRO.Infra.Data.Interfaces
{
    public interface IConsultorRepository
    {
        RetornoApi<List<Consultor>> BuscarTodosOsConsultor();
        RetornoApi<Consultor> BuscarConsultor(int id);
        RetornoApi<Consultor> CriarConsultor(Consultor consultorDTO);
        RetornoApi<Consultor> EditarConsultor(Guid id, Consultor consultorDTO);
        RetornoApi<Consultor> DeletarConsultor(int id);
    }
}
