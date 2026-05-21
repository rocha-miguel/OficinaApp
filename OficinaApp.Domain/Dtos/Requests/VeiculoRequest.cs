
namespace OficinaApp.Domain.Dtos.Requests {
    public record VeiculoRequest(

        Guid ClienteId,
        string Placa,
        string Marca,
        string Modelo,
        int Ano,
        string Cor,
        int Quilometragem

        );
}
