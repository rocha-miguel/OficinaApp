

using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Dtos.Responses {
    public record VeiculoResponse(

        Guid Id,
        Guid ClienteId,
        string ClienteNome,
        string Placa,
        string Marca,
        string Modelo,
        int Ano,
        string Cor,
        int Quilometragem,
        Status Status,
        DateTime DataCadastro

        );
}
