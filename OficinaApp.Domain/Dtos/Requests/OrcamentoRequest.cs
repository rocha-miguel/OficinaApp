
namespace OficinaApp.Domain.Dtos.Requests {
    public record OrcamentoRequest(

        Guid ClienteId,
        Guid VeiculoId,
        string Observacao,
        List<OrcamentoItemRequest> Itens

        );
}

