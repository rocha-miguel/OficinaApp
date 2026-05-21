
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Dtos.Responses {
    public record OrcamentoResponse(

        Guid Id,
        Guid ClienteId,
        Guid VeiculoId,
        StatusOrcamento StatusOrcamento,
        decimal ValorTotal,
        string? Observacao,
        DateOnly DataValidade,
        DateTime? DataAprovacao,
        DateTime DataCadastro,
        Status Status,
        List<OrcamentoItemResponse> Itens

        );
}
