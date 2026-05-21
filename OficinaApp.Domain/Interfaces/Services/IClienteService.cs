using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Services {
    public interface IClienteService : IBaseService<Cliente> {
        Task<Cliente?> ExibirPorDocumentoAsync(string documento);

        Task ValidarDocumentoUnicoAsync(string documento);

        Task ValidarEmailUnicoAsync(string email);
    }
}