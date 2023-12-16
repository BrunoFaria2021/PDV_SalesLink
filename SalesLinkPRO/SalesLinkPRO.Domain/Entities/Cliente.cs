using System.ComponentModel.DataAnnotations.Schema;

namespace SalesLinkPRO.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        // Relacionamento um-para-muitos: Um cliente pode ter várias compras
        public ICollection<Compra> Compras { get; set; }
        [ForeignKey("ConsultorId")]
        public Guid ConsultorId { get; set; }
        public Consultor Consultor { get; set; }

    }

}
