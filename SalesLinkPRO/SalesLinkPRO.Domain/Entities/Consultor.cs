namespace SalesLinkPRO.Domain.Entities
{
    public class Consultor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string AreaAtuacao { get; set; } = string.Empty;
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        // Relacionamento um-para-muitos: Um consultor pode fazer várias vendas
        public ICollection<Venda> Vendas { get; set; }
        // Relacionamento com Cliente
        public ICollection<Cliente> Clientes { get; set; }
    }
}
