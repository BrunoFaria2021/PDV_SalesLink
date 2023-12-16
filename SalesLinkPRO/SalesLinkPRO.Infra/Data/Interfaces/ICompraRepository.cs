using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.CrossCutting.Util;
using SalesLinkPRO.Domain.Entities;

namespace SalesLinkPRO.Infra.Data.Interfaces
{
    public interface ICompraRepository
    {
        RetornoApi<List<Compra>> BuscarTodasAsCompras();
        RetornoApi<Compra> BuscarCompra(string id, EnumStatusCompra enumStatusCompra);
        RetornoApi<Compra> CriarCompra(Compra compraDTO);
        RetornoApi<Compra> EditarCompra(string id, Compra compraDTO);
        RetornoApi<Compra> AtualizarStatusCompra(string id, EnumStatusCompra enumStatusCompra);
        RetornoApi<Compra> DeletarCompra(string id);
    }
}
