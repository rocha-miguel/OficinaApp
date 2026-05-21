
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Dtos.Responses {
    public record OrdemServicoResponse(

        Guid Id,
        Guid OrcamentoId,
        Guid ClienteId,
        Guid VeiculoId,
        StatusOrdemServico StatusOrdemServico,
        string Observacao,
        DateTime? DataInicio,
        DateTime? DataConclusao,
        decimal ValorTotal,
        DateTime DataCadastro,
        Status Status

        );
}
