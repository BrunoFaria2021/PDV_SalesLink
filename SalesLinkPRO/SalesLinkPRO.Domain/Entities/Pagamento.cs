using System.ComponentModel.DataAnnotations.Schema;

namespace SalesLinkPRO.Domain.Entities
{
    public class Pagamento
    {
        public Guid PagamentoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }

        // Chave estrangeira para identificar a venda associada a este pagamento

        [ForeignKey("VendaId")]
        public Guid VendaId { get; set; }
        public Venda Venda { get; set; }
    }
}