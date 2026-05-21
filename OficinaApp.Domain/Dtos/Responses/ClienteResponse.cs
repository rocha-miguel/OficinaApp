

using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Dtos.Responses {
    public record ClienteResponse(

        Guid Id,
        string Nome,
        string Documento,
        string Telefone,
        string Email,
        TipoCliente TipoCliente,
        Status Status,
        DateTime DataCadastro,
        List<VeiculoResponse> Veiculos

        );
}
