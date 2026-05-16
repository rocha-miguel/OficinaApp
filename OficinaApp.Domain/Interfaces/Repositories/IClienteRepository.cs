

using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IClienteRepository : IBaseRepository<Cliente> {

        Task<Cliente?> ExibirPorDocumento(string documento);

        Task<bool> ExisteDocumento(string documento);

        Task<bool> ExisteEmail(string email);

    }
}
