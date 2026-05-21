
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Dtos.Responses {
    public record ServicoResponse(

        Guid Id,
        string Nome,
        string Descricao,
        decimal ValorBase,
        Status Status,
        DateTime DataCadastro

        );
}
