namespace SalesLinkPRO.Application.DTO
{
    public class PagamentoDTO
    {
        public Guid PagamentoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public Guid VendaId { get; set; }
    }
}
