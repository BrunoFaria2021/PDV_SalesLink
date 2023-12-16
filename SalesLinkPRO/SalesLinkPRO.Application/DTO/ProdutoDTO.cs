namespace SalesLinkPRO.Application.DTO
{
    public class ProdutoDTO
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
    }
}
