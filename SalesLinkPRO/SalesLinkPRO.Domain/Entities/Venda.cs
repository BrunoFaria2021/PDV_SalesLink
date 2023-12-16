namespace SalesLinkPRO.Domain.Entities
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public DateTime Data { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }
    }
}
