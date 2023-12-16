using SalesLinkPRO.CrossCutting.Util;

namespace SalesLinkPRO.Domain.Entities
{
    public class Compra
    {
        public Guid Id { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataCompra { get; set; }

        public EnumStatusCompra Tipo { get; set; }
        // Chave estrangeira para identificar o cliente associado a esta compra
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
