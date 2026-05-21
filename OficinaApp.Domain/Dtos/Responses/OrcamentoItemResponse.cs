
namespace OficinaApp.Domain.Dtos.Responses {
    public record OrcamentoItemResponse(

        Guid Id,
        Guid ServicoId,
        string Descricao,
        int Quantidade,
        decimal ValorUnitario,
        decimal ValorTotal

        );
}
