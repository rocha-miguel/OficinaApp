
namespace OficinaApp.Domain.Dtos.Requests {
    public record OrcamentoItemRequest(

        Guid ServicoId,
        int Quantidade,
        decimal ValorUnitario
    );
}