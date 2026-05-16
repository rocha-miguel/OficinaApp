

using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IClienteRepository : IBaseRepository<Cliente> {

        Task<Cliente?> ExibirPorDocumentoAsync(string documento);

        Task<bool> ExisteDocumentoAsync(string documento);

        Task<bool> ExisteEmailAsync(string email);

    }
}
