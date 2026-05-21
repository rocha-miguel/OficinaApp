
using OficinaApp.Domain.Enums;

namespace OficinaApp.Domain.Dtos.Requests {
    public record ClienteRequest(

        string Nome,
        string Documento,
        string Telefone,
        string Email,
        TipoCliente TipoCliente

        );
}
