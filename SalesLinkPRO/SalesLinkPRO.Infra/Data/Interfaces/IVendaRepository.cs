using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.CrossCutting.Util;
using SalesLinkPRO.Domain.Entities;

namespace SalesLinkPRO.Infra.Data.Interfaces
{
    public interface IVendaRepository
    {
        RetornoApi<List<Venda>> BuscarTodasAsVendas();
        RetornoApi<Venda> BuscarVenda(string id);
        RetornoApi<Venda> CriarVenda(Venda vendaDTO);
        RetornoApi<Venda> EditarVenda(string id, Venda vendaDTO);
        RetornoApi<Venda> AtualizarStatusVenda(string id, EnumStatusVenda statusVenda);
        RetornoApi<Venda> DeletarVenda(string id);
    }
}
