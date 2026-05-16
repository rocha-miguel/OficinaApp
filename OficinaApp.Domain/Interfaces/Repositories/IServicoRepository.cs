

using OficinaApp.Domain.Entities;

namespace OficinaApp.Domain.Interfaces.Repositories {
    public interface IServicoRepository : IBaseRepository<Servico> {

        Task<Servico?> ExibirPorNomeAsync(string nome);

        Task<bool> ExisteNomeAsync(string nome);
    }
}
