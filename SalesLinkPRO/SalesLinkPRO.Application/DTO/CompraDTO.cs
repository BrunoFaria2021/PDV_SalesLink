using SalesLinkPRO.CrossCutting.Util;

namespace SalesLinkPRO.Application.DTO
{
    public class CompraDTO
    {
        public Guid Id { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataCompra { get; set; }
        public EnumStatusCompra Tipo { get; set; }
        public Guid ClienteId { get; set; }
    }
}