﻿namespace SalesLinkPRO.Application.DTO
{
    public class ClienteDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Guid ConsultorId { get; set; }
       
    }
}
