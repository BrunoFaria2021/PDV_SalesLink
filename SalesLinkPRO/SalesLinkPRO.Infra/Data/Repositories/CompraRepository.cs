using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.CrossCutting.Util;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;

namespace SalesLinkPRO.Infra.Data.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        public RetornoApi<Compra> AtualizarStatusCompra(string id, EnumStatusCompra enumStatusCompra)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Compra> BuscarCompra(string id, EnumStatusCompra enumStatusCompra)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<List<Compra>> BuscarTodasAsCompras()
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Compra> CriarCompra(Compra compraDTO)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Compra> DeletarCompra(string id)
        {
            throw new NotImplementedException();
        }

        public RetornoApi<Compra> EditarCompra(string id, Compra compraDTO)
        {
            throw new NotImplementedException();
        }
    }
}
