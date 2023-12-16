namespace SalesLinkPRO.Application.DTO
{

    public class ConsultorDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string AreaAtuacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        // Adicionando propriedade relacionada ao ClienteDTO
        public ICollection<ClienteDTO> Clientes { get; set; }
    }
}
