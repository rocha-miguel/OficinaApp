
namespace OficinaApp.Domain.Dtos.Requests {
    public record OrdemServicoRequest(

        Guid OrcamentoId,
        string Observacao

    );
}