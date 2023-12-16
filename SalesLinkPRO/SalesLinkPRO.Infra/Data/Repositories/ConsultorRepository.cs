using SalesLinkPRO.CrossCutting.Extensions;
using SalesLinkPRO.Domain.Entities;
using SalesLinkPRO.Infra.Data.Interfaces;
using System.Net;

namespace SalesLinkPRO.Infra.Data.Repositories
{
    public class ConsultorRepository : IConsultorRepository
    {
        private readonly ApplicationDbContext _context;

        public ConsultorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public RetornoApi<Consultor> BuscarConsultor(int id)
        {
            try
            {
                var consultor = _context.Consultor.Find(id);

                if (consultor == null)
                {
                    return new RetornoApi<Consultor>
                    {
                        Success = false,
                        Message = "Consultor não encontrado"
                    };
                }

                return new RetornoApi<Consultor>
                {
                    Data = consultor,
                    Success = true,
                    Message = "Consultor encontrado com sucesso"
                };
            }
            catch (Exception ex)
            {
                return new RetornoApi<Consultor>
                {
                    Success = false,
                    Message = $"Erro ao buscar o consultor: {ex.Message}"
                };
            }
        }

        public RetornoApi<List<Consultor>> BuscarTodosOsConsultor()
        {
            try
            {
                var consultores = _context.Consultor.ToList();

                return new RetornoApi<List<Consultor>>
                {
                    Data = consultores,
                    Success = true,
                    Message = "Consultores encontrados com sucesso"
                };
            }
            catch (Exception ex)
            {
                return new RetornoApi<List<Consultor>>
                {
                    Success = false,
                    Message = $"Erro ao buscar consultores: {ex.Message}"
                };
            }
        }

        public RetornoApi<Consultor> CriarConsultor(Consultor consultorDTO)
        {
            try
            {
                _context.Consultor.Add(consultorDTO);
                _context.SaveChanges();

                return new RetornoApi<Consultor>
                {
                    Data = consultorDTO,
                    Success = true,
                    Message = "Consultor criado com sucesso"
                };
            }
            catch (Exception ex)
            {
                return new RetornoApi<Consultor>
                {
                    Success = false,
                    Message = $"Erro ao criar o consultor: {ex.Message}"
                };
            }
        }

        public RetornoApi<Consultor> DeletarConsultor(int id)
        {
            try
            {
                var consultor = _context.Consultor.Find(id);

                if (consultor == null)
                {
                    return new RetornoApi<Consultor>
                    {
                        Success = false,
                        Message = "Consultor não encontrado para deletar"
                    };
                }

                _context.Consultor.Remove(consultor);
                _context.SaveChanges();

                return new RetornoApi<Consultor>
                {
                    Success = true,
                    Message = "Consultor deletado com sucesso"
                };
            }
            catch (Exception ex)
            {
                return new RetornoApi<Consultor>
                {
                    Success = false,
                    Message = $"Erro ao deletar o consultor: {ex.Message}"
                };
            }
        }

        public RetornoApi<Consultor> EditarConsultor(Guid id, Consultor consultorDTO)
        {
            try
            {
                var consultorExistente = _context.Consultor.FirstOrDefault(c => c.Id == id);

                if (consultorExistente == null)
                {
                    return new RetornoApi<Consultor>
                    {
                        Success = false,
                        Message = "Consultor não encontrado",
                        StatusCode = HttpStatusCode.NotFound
                    };
                }

                // Aqui, atualizamos apenas os campos que devem ser alterados
                if (consultorExistente.Nome != consultorDTO.Nome)
                {
                    consultorExistente.Nome = consultorDTO.Nome;
                }
                if (consultorExistente.CPF != consultorDTO.CPF)
                {
                    consultorExistente.CPF = consultorDTO.CPF;
                }
                // Continue atualizando outros campos conforme necessário

                _context.SaveChanges();

                return new RetornoApi<Consultor>
                {
                    Success = true,
                    Message = "Consultor atualizado com sucesso",
                    StatusCode = HttpStatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new RetornoApi<Consultor>
                {
                    Success = false,
                    Message = $"Erro ao editar o consultor: {ex.Message}",
                    StatusCode = HttpStatusCode.InternalServerError
                };
            }
        }
    }
}
